using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Dashboard : Conexion
    {

        //Fields & Properties
        private DateTime InicioFecha;
        private DateTime TerminoFecha;
        private int NumeroDias;

        public int NumClientes { get; private set; }
        public int NumProveedores { get; private set; }
        public int NumProductos { get; private set; }
        public List<KeyValuePair<string, int>> TopListaProductos { get; private set; }
        public List<KeyValuePair<string, int>> ProductosBajoStock { get; private set; }
        public List<RevenueByDate> ListaIngresoBrutos { get; private set; }
        public int NumOrdenes { get; set; }
        public decimal TotalIngresos { get; set; }
        public decimal TotalGanancias { get; set; }


        public Dashboard()
        {

        }

        //METODOS

        private void GetNumberItems()
        {
            using (var connection =  Conectar())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get Total Number of Customers
                    command.CommandText = "select count(ID_CLIENTE) from CLIENTE";
                    NumClientes = (int)command.ExecuteScalar();
                    //Get Total Number of Suppliers
                    command.CommandText = "select count(ID_PROVEEDOR) from PROVEEDOR";
                    NumProveedores = (int)command.ExecuteScalar();
                    //Get Total Number of Products
                    command.CommandText = "select count(ID_PRODUCTO) from PRODUCTO";
                    NumProductos = (int)command.ExecuteScalar();
                    //Get Total Number of Orders
                    command.CommandText = @"SELECT COUNT(ID_ORDEN_VENTA) FROM ORDEN_VENTA " +
                                            "WHERE FEC_ORDEN BETWEEN @FECHAINICIO AND @TERMINOFECHA";
                    command.Parameters.Add("@FECHAINICIO", System.Data.SqlDbType.DateTime).Value = InicioFecha;
                    command.Parameters.Add("@TERMINOFECHA", System.Data.SqlDbType.DateTime).Value = TerminoFecha;
                    NumOrdenes = (int)command.ExecuteScalar();
                }
            }
        }

        private void GetOrderAnalisys()
        {
            ListaIngresoBrutos = new List<RevenueByDate>();
            TotalGanancias = 0;
            TotalIngresos = 0;
            using (var connection = Conectar())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select FEC_ORDEN, sum(P.TOTAL)
                                            from ORDEN_VENTA AS OV
                                            INNER JOIN PAGO AS P ON P.NUM_ORDEN_VENTA = OV.NUM_ORDEN_VENTA
                                            where FEC_ORDEN between @FECHAINICIO and @TERMINOFECHA
                                            group by FEC_ORDEN";
                    command.Parameters.Add("@FECHAINICIO", System.Data.SqlDbType.DateTime).Value = InicioFecha;
                    command.Parameters.Add("@TERMINOFECHA", System.Data.SqlDbType.DateTime).Value = TerminoFecha;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                        TotalIngresos += (decimal)reader[1];
                    }
                    TotalGanancias = TotalIngresos * 0.2m;//20%
                    reader.Close();
                    //Group by Hours
                    if (NumeroDias <= 1)
                    {
                        ListaIngresoBrutos = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh tt")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Days
                    else if (NumeroDias <= 30)
                    {
                        ListaIngresoBrutos = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Weeks
                    else if (NumeroDias <= 92)
                    {
                        ListaIngresoBrutos = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Months
                    else if (NumeroDias <= (365 * 2))
                    {
                        bool isYear = NumeroDias <= 365 ? true : false;
                        ListaIngresoBrutos = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Years
                    else
                    {
                        ListaIngresoBrutos = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        private void GetProductAnalisys()
        {
            TopListaProductos = new List<KeyValuePair<string, int>>();
            ProductosBajoStock = new List<KeyValuePair<string, int>>();
            using (var connection = Conectar())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 products
                    command.CommandText = @"select top 5 P.DES_PRODUCTO, sum(DOV.CANTIDAD) as Q
                                            from DETALLE_ORDEN_VENTA AS DOV
                                            inner join PRODUCTO P on P.ID_PRODUCTO = DOV.ID_PRODUCTO
                                            inner join ORDEN_VENTA O on O.NUM_ORDEN_VENTA = DOV.NUM_ORDEN_VENTA
                                            where FEC_ORDEN between @FECHAINICIO and @TERMINOFECHA
                                            group by P.DES_PRODUCTO
                                            order by Q desc ";
                    command.Parameters.Add("@FECHAINICIO", System.Data.SqlDbType.DateTime).Value = InicioFecha;
                    command.Parameters.Add("@TERMINOFECHA", System.Data.SqlDbType.DateTime).Value = TerminoFecha;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopListaProductos.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                    //Get Understock
                    command.CommandText = @"select DES_PRODUCTO, STOCK
                                            from PRODUCTO
                                            where STOCK <= 18 and ESTADO_PRODUCTO = 1";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductosBajoStock.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }


        //METODOS PUBLICOS
        public bool LoadData(DateTime InicioFecha, DateTime TerminoFecha)
        {
            TerminoFecha = new DateTime(TerminoFecha.Year, TerminoFecha.Month, TerminoFecha.Day,
                TerminoFecha.Hour, TerminoFecha.Minute, 59);
            if (InicioFecha != this.InicioFecha || TerminoFecha != this.TerminoFecha)
            {
                this.InicioFecha = InicioFecha;
                this.TerminoFecha = TerminoFecha;
                this.NumeroDias = (TerminoFecha - InicioFecha).Days;
                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();

                Console.WriteLine("Refreshed data: {0} - {1}", InicioFecha.ToString(), TerminoFecha.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", InicioFecha.ToString(), TerminoFecha.ToString());
                return false;
            }
        }


    }
}

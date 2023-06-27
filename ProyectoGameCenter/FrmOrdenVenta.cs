using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using System.Data.SqlClient;

namespace ProyectoGameCenter
{
    public partial class FrmOrdenVenta : Form
    {
        private logCliente clienteLogic;
        private decimal total = 0;
        public static string nOrdenVenta;
        public static string totalCR;
        public static string idCliente;
        public FrmOrdenVenta()
        {
            
            InitializeComponent();  
            LlenarDatosEstadoOrdenVenta();
            ListarVentas();
            clienteLogic = new logCliente();
        }

        public void ListarVentas()
        {
            dgvOrdenVenta.DataSource = logOrdenVenta.Instancia.ListarVentas();
        }

        public void ListarDetalleVentas()
        {
            dgvDetalleOrdenVenta.DataSource = logDetalleOrdenVenta.Instancia.ListarDetalleOrdenVenta();
        }

        public void LlenarDatosEstadoOrdenVenta()
        {
            cboEstado.DataSource = logEstadoOrdenVenta.Instancia.ListaEstadoOrdenVenta();
            cboEstado.DisplayMember = "DES_ESTADO_OV";
            cboEstado.ValueMember = "ID_EST_ORDEN_VENTA";
        }

        public void LimpiarVariables()
        {
            txtIDOrdenVenta.Text = "";
            dateTimePicker1.ResetText();
            txtResultadoBusquedaCliente.Text = "";
            txtIDEmpleado.Text = "";
            cboEstado.SelectedIndex = default;
            gbOrdenVenta.Enabled = false;
        }

        public void LimpiarVariablesDetalle()
        {
            txtIDProducto.Text = "";
            txtDesProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtTotal.Text = "";
            txtStock.Text = "";
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Busca Producto
                entProducto entProducto = new entProducto();
                entProducto = logProducto.Instancia.BuscarIDProducto(Convert.ToInt32(txtIDProducto.Text.Trim()));
                if (entProducto != null)
                {
                    txtDesProducto.Text = entProducto.desProducto;
                    txtStock.Text = entProducto.stockProd.ToString();
                    txtPrecio.Text = entProducto.precioProd.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no existe", "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

        }

        private void btnBuscaridCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(txtIDCliente.Text);

                string identificacion = clienteLogic.ObtenerIdentificacionClientePorID(idCliente);

                if (!string.IsNullOrEmpty(identificacion))
                {
                    txtResultadoBusquedaCliente.Text = identificacion;
                }
                else
                {
                    txtResultadoBusquedaCliente.Text = "No se encontró el cliente.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenVenta ordVenta = new entOrdenVenta();
                ordVenta.numOrdenVenta = Convert.ToInt32(txtNOrdenVenta.Text.Trim());
                ordVenta.fechaOrden = dateTimePicker1.Value;
                ordVenta.idCliente = Convert.ToInt32(txtIDCliente.Text.Trim());
                ordVenta.estOrdenVenta = Convert.ToInt32(cboEstado.SelectedValue);
                ordVenta.idUsuario = Convert.ToInt32(txtIDEmpleado.Text.Trim());
                logOrdenVenta.Instancia.InsertaOrdenVenta(ordVenta);
                gbDetalleOrdenVenta.Enabled = true;
                MessageBox.Show("Orden de Venta registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbOrdenVenta.Enabled = false;
            ListarVentas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbOrdenVenta.Enabled = true;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrdenVenta.SelectedRows.Count > 0)
                {
                    entOrdenVenta c = new entOrdenVenta();
                    c.idOrdenVenta = int.Parse(txtIDOrdenVenta.Text.Trim());
                   logOrdenVenta.Instancia.AnulaOrdenVenta(c);
                }
                else
                {
                    MessageBox.Show("Escoge un elemento primero");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            txtNOrdenVenta.Text = "";
            ListarVentas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNOrdenVenta.Text = "";
            LimpiarVariables();
        }

        private void dgvOrdenVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvOrdenVenta.Rows[e.RowIndex];
            txtIDOrdenVenta.Text = filaActual.Cells[0].Value.ToString();
            txtNOrdenVenta.Text = filaActual.Cells[1].Value.ToString();
            dateTimePicker1.Text = filaActual.Cells[2].Value.ToString();
            txtIDCliente.Text = filaActual.Cells[3].Value.ToString();
            txtIDEmpleado.Text = filaActual.Cells[4].Value.ToString();
            cboEstado.SelectedValue = Convert.ToInt32(filaActual.Cells[5].Value); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                entDetalleOrdenVenta DetalleOV = new entDetalleOrdenVenta();
                DetalleOV.NUM_ORDEN_VENTA = int.Parse(txtNOrdenVenta.Text.Trim());
                DetalleOV.ID_PRODUCTO = int.Parse(txtIDProducto.Text.Trim());
                DetalleOV.CANTIDAD = int.Parse(txtCantidad.Text.Trim());
                DetalleOV.PRECIO = decimal.Parse(txtPrecio.Text.Trim());
                DetalleOV.TOTAL = int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecio.Text);
                // Llamar a la función InsertarCliente
                Boolean insertado = logDetalleOrdenVenta.Instancia.InsertaDetalleOrdenVenta(DetalleOV);

                if (insertado)
                {
                    MessageBox.Show("El Producto se agregó exitosamente al DETALLE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    total = total + (int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecio.Text));
                    txtTotal.Text = total.ToString();
                    ListarDetalleVentas();
                }
                else
                {
                    MessageBox.Show("No hay STOCK SUFICIENTE de ese PRODUCTO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTotal.Text = "";
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbOrdenVenta.Enabled = false;
            gbDetalleOrdenVenta.Enabled=false;
        }

        private void btnCPago_Click(object sender, EventArgs e)
        {
            idCliente = txtIDCliente.Text;
            nOrdenVenta = txtNOrdenVenta.Text;
            totalCR = txtTotal.Text;
            FrmCronogramaPago Cpago = new FrmCronogramaPago();
            Cpago.StartPosition = FormStartPosition.CenterScreen;
            Cpago.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            LimpiarVariablesDetalle();
            txtNOrdenVenta.Clear();
            txtIDCliente.Clear();
            dgvDetalleOrdenVenta.DataSource = null;
            dgvDetalleOrdenVenta.Rows.Clear();
            dgvDetalleOrdenVenta.Columns.Clear();
            ListarVentas();
        }

        private void btnBuscarOV_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenVenta OrdVenta = new entOrdenVenta();
                OrdVenta.fechaOrden = dtpOrdenVenta.Value;
                dgvOrdenVenta.DataSource = logOrdenVenta.Instancia.BuscaFechaVenta(OrdVenta);
                if (dgvOrdenVenta.Rows.Count == 0)
                {
                    MessageBox.Show("El existen ventas de esta fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarVentas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }
    }
}

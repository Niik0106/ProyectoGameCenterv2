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

namespace ProyectoGameCenter
{
    public partial class FrmOrdenVenta : Form
    {
        private logCliente clienteLogic;
        public FrmOrdenVenta()
        {
            InitializeComponent();
            LlenarDatosEstadoOrdenVenta();
            clienteLogic = new logCliente();
        }

        public void LlenarDatosEstadoOrdenVenta()
        {
            cboEstado.DataSource = logEstadoOrdenVenta.Instancia.ListaEstadoOrdenVenta();
            cboEstado.DisplayMember = "DES_ESTADO_OV";
            cboEstado.ValueMember = "ID_EST_ORDEN_VENTA";
        }




        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Busca Producto
            entProducto entProducto = new entProducto();
            entProducto = logProducto.Instancia.BuscaIDProducto(Convert.ToInt32(txtIDProducto.Text.Trim()));
            if (entProducto != null)
            {
                txtDesProducto.Text = entProducto.desProducto;
                txtCantidadVendida.Text = entProducto.stockProd.ToString();
                txtPrecio.Text = entProducto.precioProd.ToString();
            }
            else
            {
                MessageBox.Show("Producto no existe", "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

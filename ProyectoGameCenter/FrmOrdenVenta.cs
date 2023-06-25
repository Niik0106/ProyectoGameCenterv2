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
            ListarVentas();
            clienteLogic = new logCliente();
        }

        public void ListarVentas()
        {
            dgvOrdenVenta.DataSource = logOrdenVenta.Instancia.ListarVentas();
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
            txtIDCliente.Text = "";
            txtResultadoBusquedaCliente.Text = "";
            txtIDEmpleado.Text = "";
            cboEstado.SelectedIndex = default;
            gbOrdenVenta.Enabled = false;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            txtNOrdenVenta.Text = "";
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
            cboEstado.Text = filaActual.Cells[5].Value.ToString(); 
        }
    }
}

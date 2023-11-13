using AccesoDatos;
using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace ProyectoGameCenter
{
    public partial class FrmNotaSalida : Form
    {
        public FrmNotaSalida()
        {
            InitializeComponent();
            ListarNotaSalida();
            ListarVentas();
            ListarDetalleNotaSalida();
        }

        public void ListarNotaSalida()
        {
            dgvNotaSalida.DataSource = logNotaSalida.Instancia.ListarNotaSalida();
        }

        public void ListarDetalleNotaSalida()
        {
            dgvDetalleNotaSalida.DataSource = logDetalleNotaSalida.Instancia.ListarDetalleNotaSalida();
        }

        public void ListarVentas()
        {
            dgvOrdenVenta.DataSource = logOrdenVenta.Instancia.ListarVentas();
        }

        private void FrmNotaSalida_Load(object sender, EventArgs e)
        {
            dgvNotaSalida.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        public void LimpiarVariables()
        {
            txtIDNotaSalida.Text = "";
            dtpFechaNotaSalida.ResetText();
            txtNNotaSalida.Text = "";
            txtNumOrden.Text = "";
            dtpFechaOrden.ResetText();
            cbxEstado.Checked = default;
        }

        private void dgvOrdenVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvOrdenVenta.Rows[e.RowIndex];
                string numOrdenVenta = (string)dgvOrdenVenta.Rows[e.RowIndex].Cells[1].Value;
                txtNumOrden.Text = filaActual.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void btnBuscarOV_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenVenta ordenVenta = new entOrdenVenta();
                ordenVenta.fechaOrden = dtpFechaOrden.Value;
                dgvOrdenVenta.DataSource = logOrdenVenta.Instancia.BuscaFechaVenta(ordenVenta);
                if (dgvOrdenVenta.Rows.Count == 0)
                {
                    MessageBox.Show("No existen ventas de esta fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarVentas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumOrden.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar la descripcion de un Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entNotaSalida Notasalida = new entNotaSalida();
                    //Notasalida.numeroOrdenCompra = Convert.ToInt32(txtNumOrdenCompra.Text.Trim());
                    Notasalida.fechaEmision = dtpFechaNotaSalida.Value;
                    Notasalida.numOrdenVenta = txtNumOrden.Text.Trim();
                    Notasalida.estado = cbxEstado.Checked;
                    logNotaSalida.Instancia.InsertarNotaSalida(Notasalida);

                    MessageBox.Show("Nota de Salida registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error.." + ex);
            }
            ListarNotaSalida();
        }

        private void dgvNotaSalida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvNotaSalida.Rows[e.RowIndex];
                txtIDNotaSalida.Text = filaActual.Cells[0].Value.ToString();
                txtNNotaSalida.Text = filaActual.Cells[1].Value.ToString();
                dtpFechaNotaSalida.Text = filaActual.Cells[2].Value.ToString();
                txtNumOrden.Text = filaActual.Cells[3].Value.ToString();
                cbxEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            
        }

        private void txtDesProducto__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDesProducto.Text.Equals(""))
                {
                    ListarDetalleNotaSalida();
                }
                else
                {
                    entProducto producto = new entProducto();
                    producto.DES_PRODUCTO = txtDesProducto.Text;
                    dgvDetalleNotaSalida.DataSource = logProducto.Instancia.BuscaDescProducto(producto);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void dgvDetalleNotaSalida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvDetalleNotaSalida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvDetalleNotaSalida.Rows[e.RowIndex];
                txtIDProducto.Text = filaActual.Cells[0].Value.ToString();
                txtDesProducto.Text = filaActual.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                entDetalleNotaSalida DetalleNotaSalida = new entDetalleNotaSalida();
                DetalleNotaSalida.Num_NotaSalida = int.Parse(txtNNotaSalida.Text.Trim());
                DetalleNotaSalida.ID_Producto = int.Parse(txtIDProducto.Text.Trim());
                DetalleNotaSalida.Descripcion = txtDesProducto.Text.Trim();
                DetalleNotaSalida.Cantidad = int.Parse(txtCantidad.Text.Trim());
                Boolean insertado = logDetalleNotaSalida.Instancia.InsertarDetalleNotaSalida(DetalleNotaSalida);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarDetalleNotaSalida();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDNotaSalida.Text.Equals("") | txtNNotaSalida.Text.Equals("") | txtNumOrden.Text.Equals(""))
                {
                    MessageBox.Show("Deben estar llenos los campos ID Nota Entrada, Numero Nota Entrada y Numero Orden Compra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entNotaSalida notasalida = new entNotaSalida();
                    notasalida.idNotaSalida = Convert.ToInt32(txtIDNotaSalida.Text);
                    logNotaSalida.Instancia.DeshabilitarNotaSalida(notasalida.idNotaSalida);
                    MessageBox.Show("Nota de Salida inhabilitado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarNotaSalida();
                    LimpiarVariables();
                    gbNotaSalida.Enabled = false;
                    gbDetalleNotaSalida.Enabled=false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void btnBuscarNS_Click(object sender, EventArgs e)
        {
            try
            {
                entNotaSalida NotaSalida = new entNotaSalida();
                NotaSalida.fechaEmision = dtpBuscarFecha.Value;
                dgvNotaSalida.DataSource = logNotaSalida.Instancia.BuscaFecha(NotaSalida);
                if (dgvNotaSalida.Rows.Count == 0)
                {
                    MessageBox.Show("NO existen Notas de Salida de esta fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarNotaSalida();
                    LimpiarVariables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }
    }
}

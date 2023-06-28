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

namespace ProyectoGameCenter
{
    public partial class NotaSalida : Form
    {
        public NotaSalida()
        {
            InitializeComponent();
            ListarNotaSalida();
            ListarDetalleNotaSalida();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Desabilita el registro de la nota de salida
            try
            {
                if (dgvNotaSalida.SelectedRows.Count > 0)
                {
                    entNotaSalida notaSalida = new entNotaSalida();
                    notaSalida.numNotaSalida = Convert.ToInt32(dgvNotaSalida.CurrentRow.Cells["numNotaSalida"].Value.ToString());
                    logNotaSalida.Instancia.DeshabilitarNotaSalida(notaSalida.numNotaSalida);
                    MessageBox.Show("Se deshabilito correctamente");
                    ListarNotaSalida();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar Nota de Salida " + ex.Message);
            }
        }

        private void ListarNotaSalida()
        {
            dgvNotaSalida.DataSource = logNotaSalida.Instancia.ListarNotaSalida();
        }
        private void ListarDetalleNotaSalida()
        {
            dgvDetalleNotaSalida.DataSource = logDetalleNotaSalida.Instancia.ListarDetalleNotaSalida();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                //valida que los textbox del groupbox gbNotaSalida no esten vacios
                if (txtNumNSalida.Text == "" || txtNumOrdenV.Text == "" || txtCliente.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else
                {
                    entNotaSalida notaSalida = new entNotaSalida();
                    notaSalida.numNotaSalida = Convert.ToInt32(txtNumNSalida.Text.Trim());
                    notaSalida.fechaEmision = dtFechaEmision.Value;
                    notaSalida.numOrdenVenta = Convert.ToInt32(txtNumOrdenV.Text.Trim());
                    notaSalida.estado = cbxEstado.Checked;
                    logNotaSalida.Instancia.InsertarNotaSalida(notaSalida);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar Nota de Salida " + ex.Message);
            }

            ListarNotaSalida();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtNumNSalida.Enabled = false;
            txtNumOrdenV.Enabled = false;
            txtCliente.Enabled = false;
            btnBuscarOrden.Enabled = false;
            dtFechaEmision.Enabled = false;
            cbxEstado.Enabled = false;
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
            btnBuscarProducto.Enabled = false;
            btnAñadir.Enabled = false;
            btnQuitar.Enabled = false;
            txtIDProducto.Enabled = false;
            txtCantidad.Enabled = false;
        }

        private void Limpiar()
        {
            txtNumNSalida.Text = "";
            txtNumOrdenV.Text = "";
            cbxEstado.Checked = false;
            txtCliente.Text = "";
            txtIDProducto.Text = "";
            txtCantidad.Text = "";
            txtDesProducto.Text = "";
        }

        private void Enable()
        {
            txtNumNSalida.Enabled = true;
            txtNumOrdenV.Enabled = true;
            cbxEstado.Enabled = true;
            dtFechaEmision.Enabled = true;
            txtCliente.Enabled = true;
            btnBuscarOrden.Enabled = true;
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
            btnQuitar.Enabled = true;
            btnAñadir.Enabled = true;
            btnBuscarProducto.Enabled = true;
            txtIDProducto.Enabled = true;
            txtCantidad.Enabled = true;
        }

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            //Busca la orden de venta por el numero de orden de venta
            try
            {
                entOrdenVenta ordenVenta = new entOrdenVenta();
                ordenVenta = logOrdenVenta.Instancia.BuscarOrdenVentaIDCliente(Convert.ToInt32(txtNumOrdenV.Text.Trim()));
                if (ordenVenta != null)
                {
                    txtCliente.Text = ordenVenta.idCliente.ToString();
                }
                else
                {
                    MessageBox.Show("Orden de Venta no existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar Orden de Venta " + ex.Message);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Buscar producto por el codigo de producto
            try
            {
                entProducto producto = new entProducto();
                producto = logProducto.Instancia.BuscarIDProducto(Convert.ToInt32(txtIDProducto.Text.Trim()));
                if (producto != null)
                {
                    txtDesProducto.Text = producto.desProducto;
                }
                else
                {
                    MessageBox.Show("Producto no existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar Producto " + ex.Message);
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //Inserta el detalle de la nota de salida
            try
            {
                if (txtIDProducto.Text == "" || txtCantidad.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else
                {
                    entDetalleNotaSalida detalleNotaSalida = new entDetalleNotaSalida();
                    detalleNotaSalida.numNotaSalida = Convert.ToInt32(txtNumNSalida.Text.Trim());
                    detalleNotaSalida.idProducto = Convert.ToInt32(txtIDProducto.Text.Trim());
                    detalleNotaSalida.cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
                    logDetalleNotaSalida.Instancia.InsertarDetalleNotaSalida(detalleNotaSalida);
                    Limpiar();
                    ListarDetalleNotaSalida();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar Detalle Nota de Salida " + ex.Message);
            }
        }
    }
}

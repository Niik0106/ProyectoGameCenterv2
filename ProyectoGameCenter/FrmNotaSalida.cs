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

namespace ProyectoGameCenter
{
    public partial class FrmNotaSalida : Form
    {
        public FrmNotaSalida()
        {
            InitializeComponent();
            ListarNotas();
            LlenarDatosEstadoNotaSalida();
        }

        private void gbNotaSalida_Enter(object sender, EventArgs e)
        {

        }

        public void ListarNotas()
        {
            dgvNotaSalida.DataSource = logNotaSalida.Instancia.ListarNotaSalida();
        }

        public void LlenarDatosEstadoNotaSalida()
        {
            cboEstado.DataSource = logEstadoNotaSalida.Instancia.ListaEstadoNotaSalida();
            cboEstado.DisplayMember = "DES_ESTADO_NS";
            cboEstado.ValueMember = "ID_EST_NOTA_SALIDA";
        }

        private void btnAgregarNotaSalida_Click(object sender, EventArgs e)
        {
            try
            {
                int validacionOV = logNotaSalida.Instancia.Verificar_Orden_Venta(txtN_Orden_Venta.Text.ToString());

                //label1.Text = validacionOV;
                if (validacionOV == 0)
                {
                    MessageBox.Show("La orden de venta no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    entNotaSalida notSalida = new entNotaSalida();
                    //notSalida.idNotaSalida = Convert.ToInt32(txtIDNotaSalida.Text.Trim());
                    notSalida.numNotaSalida = Convert.ToInt32(txtNNotaSalida.Text.Trim());
                    notSalida.fechaEmision = dateTimePicker1.Value;
                    notSalida.numOrdenVenta = txtN_Orden_Venta.Text.Trim();
                    notSalida.estado = Convert.ToInt32(cboEstado.SelectedValue);

                    logNotaSalida.Instancia.InsertarNotaSalida(notSalida);
                    gbDetalleNotaSalida.Enabled = true;
                    MessageBox.Show("Orden de Venta registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            gbNotaSalida.Enabled = false;
            ListarNotas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbNotaSalida.Enabled = true;
            gbDetalleNotaSalida.Enabled = true;
            LimpiarVariables();
            LimpiarVariablesDetalle();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNotaSalida.SelectedRows.Count > 0)
                {
                    entNotaSalida c = new entNotaSalida();
                    c.idNotaSalida = int.Parse(txtIDNotaSalida.Text.Trim());
                    logNotaSalida.Instancia.DeshabilitarNotaSalida(c);
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
            txtN_Orden_Venta.Text = "";
            ListarNotas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            LimpiarVariablesDetalle();
            txtN_Orden_Venta.Clear();
            dgvDetalleNotaSalida.DataSource = null;
            dgvDetalleNotaSalida.Rows.Clear();
            dgvDetalleNotaSalida.Columns.Clear();
            //ListarVentas();
            dgvDetalleNotaSalida.Enabled = false;
            txtIDProducto.Enabled = true;
            txtCantidad.Enabled = true;
            btnAgregarProducto.Enabled = true;
            btnFinalizar.Enabled = true;
            btnBuscarProducto.Enabled = true;
            gbDetalleNotaSalida.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarOV_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarVariables()
        {
            txtIDNotaSalida.Text = "";
            dateTimePicker1.ResetText();
            cboEstado.SelectedIndex = default;

        }

        public void LimpiarVariablesDetalle()
        {
            txtIDProducto.Text = "";
            txtDesProducto.Text = "";
            txtCantidad.Text = "";
        }

    }
}

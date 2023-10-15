using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace ProyectoGameCenter
{
    public partial class FrmTipoPago : Form
    {
        public FrmTipoPago()
        {
            InitializeComponent();
            ListarTipoPago();
        }
        public void ListarTipoPago()
        {
            dgvTipoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
        }

        public void LimpiarVariables()
        {
            txtIDTipoPago.Text = "";
            txtDescripcionTipo.Text = "";
            cbxTipoPago.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbTipoPago.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariables();
            txtDescripcionTipo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbTipoPago.Enabled = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbTipoPago.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcionTipo.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entMetodoPago metodo = new entMetodoPago();
                    metodo.DES_METODO_PAGO = txtDescripcionTipo.Text.Trim();
                    metodo.ESTADO_METODO_PAGO = cbxTipoPago.Checked;
                    logMetodoPago.Instancia.InsertaMetodoPago(metodo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbTipoPago.Enabled = false;
            btnModificar.Visible = true;
            ListarTipoPago();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago metodo = new entMetodoPago();
                metodo.ID_METODO_PAGO = int.Parse(txtIDTipoPago.Text.Trim());
                metodo.DES_METODO_PAGO = txtDescripcionTipo.Text.Trim();
                metodo.ESTADO_METODO_PAGO = cbxTipoPago.Checked;
                logMetodoPago.Instancia.EditaMetodoPago(metodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbTipoPago.Enabled = false;
            ListarTipoPago();
        }

        private void btnDeshabilitarMetdPag_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago metodo = new entMetodoPago();
                metodo.ID_METODO_PAGO = int.Parse(txtIDTipoPago.Text.Trim());
                cbxTipoPago.Checked = false;
                metodo.ESTADO_METODO_PAGO = cbxTipoPago.Checked;
                logMetodoPago.Instancia.DeshabilitaMetodoPago(metodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbTipoPago.Enabled = false;
            ListarTipoPago();
        }

        private void dgvMetodoPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvTipoPago.Rows[e.RowIndex];
                txtIDTipoPago.Text = filaActual.Cells[0].Value.ToString();
                txtDescripcionTipo.Text = filaActual.Cells[1].Value.ToString();
                cbxTipoPago.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }   
        }
    }
}

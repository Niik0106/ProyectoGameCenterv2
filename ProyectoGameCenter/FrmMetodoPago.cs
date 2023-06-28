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
    public partial class FrmMetodoPago : Form
    {
        public FrmMetodoPago()
        {
            InitializeComponent();
            ListarMetodoPago();
        }
        public void ListarMetodoPago()
        {
            dgvMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
        }

        public void LimpiarVariables()
        {
            txtIDMetodoPago.Text = "";
            txtDescripcionMetodoPago.Text = "";
            cbxEstadoMetdPago.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbMetodoPago.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariables();
            txtDescripcionMetodoPago.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbMetodoPago.Enabled = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbMetodoPago.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago metodo = new entMetodoPago();
                metodo.DES_METODO_PAGO = txtDescripcionMetodoPago.Text.Trim();
                metodo.ESTADO_METODO_PAGO = cbxEstadoMetdPago.Checked;
                logMetodoPago.Instancia.InsertaMetodoPago(metodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMetodoPago.Enabled = false;
            btnModificar.Visible = true;
            ListarMetodoPago();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago metodo = new entMetodoPago();
                metodo.ID_METODO_PAGO = int.Parse(txtIDMetodoPago.Text.Trim());
                metodo.DES_METODO_PAGO = txtDescripcionMetodoPago.Text.Trim();
                metodo.ESTADO_METODO_PAGO = cbxEstadoMetdPago.Checked;
                logMetodoPago.Instancia.EditaMetodoPago(metodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMetodoPago.Enabled = false;
            ListarMetodoPago();
        }

        private void btnDeshabilitarMetdPag_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago metodo = new entMetodoPago();
                metodo.ID_METODO_PAGO = int.Parse(txtIDMetodoPago.Text.Trim());
                cbxEstadoMetdPago.Checked = false;
                metodo.ESTADO_METODO_PAGO = cbxEstadoMetdPago.Checked;
                logMetodoPago.Instancia.DeshabilitaMetodoPago(metodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMetodoPago.Enabled = false;
            ListarMetodoPago();
        }

        private void dgvMetodoPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvMetodoPago.Rows[e.RowIndex];
                txtIDMetodoPago.Text = filaActual.Cells[0].Value.ToString();
                txtDescripcionMetodoPago.Text = filaActual.Cells[1].Value.ToString();
                cbxEstadoMetdPago.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }   
        }
    }
}

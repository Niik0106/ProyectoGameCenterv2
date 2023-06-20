using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGameCenter
{
    public partial class FrmClienteJuridico : Form
    {
 
        public FrmClienteJuridico()
        {
            InitializeComponent();
            ListarClienteJuridico();
            gbClienteJuridico.Enabled = false;
        }
        public void ListarClienteJuridico()
        {
            dgvClienteJuridico.DataSource = logClienteJuridico.Instancia.ListaClienteJuridico();
        }

        private void LimpiarVariables()
        {
            txtIDCliente.Text = "";
            txtRUC.Text = "";
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
            txtCodigoUbigeo.Text = "";
            txtDepartamento.Text = "";
            txtProvincia.Text = "";
            txtDistrito.Text = "";
            txtDireccion.Text = "";
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.DarkViolet;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbClienteJuridico.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariables();
            txtRUC.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbClienteJuridico.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnInhabilitarCliJur_Click(object sender, EventArgs e)
        {
            try
            {
                entClienteJuridico cj = new entClienteJuridico();
                cj.ID_CLIENTE = int.Parse(txtIDCliente.Text.Trim());
                cbxEstadoCliJur.Checked = false;
                cj.ESTADO_CLIENTE_J = cbxEstadoCliJur.Checked;
                logClienteJuridico.Instancia.DeshabilitarClienteJuridico(cj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbClienteJuridico.Enabled = false;
            ListarClienteJuridico();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entClienteJuridico cj = new entClienteJuridico();
                cj.RUC_CLIENTE_J = txtRUC.Text.Trim();
                cj.RAZON_SOCIAL_CLIENTE_J = txtRazonSocial.Text.Trim();
                cj.TEL_CLIENTE_J = txtTelefono.Text.Trim();
                cj.COD_UBIGEO = int.Parse(txtCodigoUbigeo.Text.Trim());
                cj.DIR_CLIENTE_J = txtDireccion.Text.Trim();
                cj.ESTADO_CLIENTE_J = cbxEstadoCliJur.Checked;
                // Llamar a la función InsertarCliente
                Boolean insertado = logClienteJuridico.Instancia.InsertaClienteJuridico(cj);

                if (insertado)
                {
                    MessageBox.Show("El Cliente se agregó exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya existe un registro con el mismo RUC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbClienteJuridico.Enabled = false;
            ListarClienteJuridico();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entClienteJuridico cj = new entClienteJuridico();
                cj.ID_CLIENTE = int.Parse(txtIDCliente.Text.Trim());
                cj.RUC_CLIENTE_J = txtRUC.Text.Trim();
                cj.RAZON_SOCIAL_CLIENTE_J = txtRazonSocial.Text.Trim();
                cj.TEL_CLIENTE_J = txtTelefono.Text.Trim();
                cj.COD_UBIGEO = int.Parse(txtCodigoUbigeo.Text.Trim());
                cj.DIR_CLIENTE_J = txtDireccion.Text.Trim();
                cj.ESTADO_CLIENTE_J = cbxEstadoCliJur.Checked;
                // Llamar a la función InsertarCliente
                Boolean editado = logClienteJuridico.Instancia.EditaClienteJuridico(cj);

                if (editado)
                {
                    MessageBox.Show("El Cliente se Modifico exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya existe un registro con el mismo RUC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbClienteJuridico.Enabled = false;
            ListarClienteJuridico();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbClienteJuridico.Enabled = false;
            btnModificar.Visible = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
        }

        private void dgvClienteJuridico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvClienteJuridico.Rows[e.RowIndex];
            txtIDCliente.Text = filaActual.Cells[0].Value.ToString();
            txtRUC.Text = filaActual.Cells[1].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[3].Value.ToString();
            txtCodigoUbigeo.Text = filaActual.Cells[4].Value.ToString();
            txtDireccion.Text = filaActual.Cells[5].Value.ToString();
            cbxEstadoCliJur.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

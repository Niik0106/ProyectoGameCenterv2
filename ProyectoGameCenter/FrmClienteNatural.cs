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
    public partial class FrmClienteNatural : Form
    {

        public FrmClienteNatural()
        {
            InitializeComponent();
            ListarClientesNaturales();
        }

        private void btnAgregarCN_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnAgregarCN_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.White;
        }

        private void btnAgregarCN_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.DarkViolet;
        }

        private void btnModificarCN_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.ForeColor = Color.White;
        }

        private void btnModificarCN_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.ForeColor = Color.DarkViolet;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.DarkViolet;
        }

        private void btnNuevoCN_MouseEnter(object sender, EventArgs e)
        {
            btnNuevo.ForeColor = Color.White;
        }

        private void btnNuevoCN_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.ForeColor = Color.DarkViolet;
        }

        private void btnEditarCN_MouseEnter(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.White;
        }

        private void btnEditarCN_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.DarkViolet;
        }

        private void btnEliminarCN_MouseEnter(object sender, EventArgs e)
        {
            btnInhabilitarCliNat.ForeColor = Color.White;
        }

        private void btnEliminarCN_MouseLeave(object sender, EventArgs e)
        {
            btnInhabilitarCliNat.ForeColor = Color.DarkViolet;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.DarkViolet;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDNI.Text.Equals("") || txtNombres.Text.Equals("") || txtApellidos.Text.Equals("") || txtTelefono.Text.Equals("") || txtCodigoUbigeo.Text.Equals("") || txtDireccion.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entClienteNatural cliente = new entClienteNatural();
                    cliente.DNI = txtDNI.Text;
                    cliente.NOMBRE_CLI = txtNombres.Text;
                    cliente.APELLIDO_CLI = txtApellidos.Text;
                    cliente.TEL_CLIENTE = txtTelefono.Text;
                    cliente.COD_UBIGEO = Convert.ToInt32(txtCodigoUbigeo.Text);
                    cliente.DIR_CLIENTE = txtDireccion.Text;
                    cliente.ESTADO_CLIENTE = cbxEstadoCliNat.Checked;
                    logClienteNatural.Instancia.InsertarClienteNatural(cliente);
                    MessageBox.Show("Cliente Natural registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarClientesNaturales();
            LimpiarVariables();
            gbClientesNatural.Enabled = false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //MODIFICAR CLIENTE NATURAL
            if (txtDNI.Text.Equals("") || txtNombres.Text.Equals("") || txtApellidos.Text.Equals("") || txtTelefono.Text.Equals("") || txtCodigoUbigeo.Text.Equals("") || txtDireccion.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entClienteNatural cliente = new entClienteNatural();
                cliente.ID_CLIENTE = Convert.ToInt32(txtIDCliente.Text);
                cliente.DNI = txtDNI.Text;
                cliente.NOMBRE_CLI = txtNombres.Text;
                cliente.APELLIDO_CLI = txtApellidos.Text;
                cliente.TEL_CLIENTE = txtTelefono.Text;
                cliente.COD_UBIGEO = Convert.ToInt32(txtCodigoUbigeo.Text);
                cliente.DIR_CLIENTE = txtDireccion.Text;
                cliente.ESTADO_CLIENTE = cbxEstadoCliNat.Checked;
                logClienteNatural.Instancia.EditarClienteNatural(cliente);
                MessageBox.Show("Cliente Natural modificado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarClientesNaturales();
                LimpiarVariables();
                gbClientesNatural.Enabled = false;
            }
        }
        public void ListarClientesNaturales()
        {
            dgvClienteNatural.DataSource = logClienteNatural.Instancia.ListarClienteNatural();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbClientesNatural.Enabled = true;
            txtIDCliente.Enabled = false;
            btnModificar.Visible = false;
            LimpiarVariables();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbClientesNatural.Enabled = true;
            txtIDCliente.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }
        private void LimpiarVariables()
        {
            txtIDCliente.Clear();
            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCodigoUbigeo.Clear();
            txtDepartamento.Clear();
            txtProvincia.Clear();
            txtDistrito.Clear();
            txtDireccion.Clear();
            txtBuscarDNI.Clear();
            cbxEstadoCliNat.Checked = false;
        }

        private void dgvClienteNatural_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvClienteNatural.Rows[e.RowIndex];
            txtIDCliente.Text = filaActual.Cells[3].Value.ToString();
            txtDNI.Text = filaActual.Cells[0].Value.ToString();
            txtNombres.Text = filaActual.Cells[1].Value.ToString();
            txtApellidos.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[4].Value.ToString();
            txtCodigoUbigeo.Text = filaActual.Cells[5].Value.ToString();
            txtDireccion.Text = filaActual.Cells[6].Value.ToString();
            cbxEstadoCliNat.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbClientesNatural.Enabled = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            LimpiarVariables();
        }

        private void btnInhabilitarCliNat_Click(object sender, EventArgs e)
        {
            //DESHABILITAR CLIENTE NATURAL
            if (txtIDCliente.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entClienteNatural cliente = new entClienteNatural();
                cliente.ID_CLIENTE = Convert.ToInt32(txtIDCliente.Text);
                logClienteNatural.Instancia.DeshabilitarClienteNatural(cliente);
                MessageBox.Show("Cliente Natural inhabilitado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarClientesNaturales();
                LimpiarVariables();
                gbClientesNatural.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnBuscarCliNat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarDNI.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entClienteNatural cliente = new entClienteNatural();
                    cliente.DNI = txtBuscarDNI.Text;
                    dgvClienteNatural.DataSource = logClienteNatural.Instancia.BuscarDniClienteNatural(cliente);
                    if (dgvClienteNatural.Rows.Count == 0)
                    {
                        MessageBox.Show("El cliente no se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientesNaturales();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void txtBuscarDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscarDNI.Text == "")
            {
                dgvClienteNatural.DataSource = logClienteNatural.Instancia.ListarClienteNatural();
            }
        }
    }
}

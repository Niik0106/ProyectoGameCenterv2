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
        private logDniRuc logDniRuc;
        public FrmClienteJuridico()
        {
            InitializeComponent();
            ListarClienteJuridico();
            gbClienteJuridico.Enabled = false;
            logDniRuc = new logDniRuc();
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
        {//DESHABILITAR CLIENTE NATURAL
            if (txtIDCliente.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entClienteJuridico cliente = new entClienteJuridico();
                cliente.ID_CLIENTE = Convert.ToInt32(txtIDCliente.Text);
                logClienteJuridico.Instancia.DeshabilitarClienteJuridico(cliente);
                MessageBox.Show("Cliente inhabilitado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarClienteJuridico();
                LimpiarVariables();
                gbClienteJuridico.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRUC.Text.Equals("") | txtRazonSocial.Text.Equals("") | txtTelefono.Text.Equals("") | txtDireccion.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entClienteJuridico cj = new entClienteJuridico();
                    cj.RUC_CLIENTE = txtRUC.Text.Trim();
                    if(cj.RUC_CLIENTE.Length != 11)
                    {
                        MessageBox.Show("El RUC debe tener 11 dígitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cj.RAZON_SOCIAL = txtRazonSocial.Text.Trim();                   
                    cj.DIRECCION = txtDireccion.Text.Trim();
                    cj.DEPARTAMENTO = txtDepartamento.Text.Trim();
                    cj.PROVINCIA = txtProvincia.Text.Trim();
                    cj.DISTRITO = txtDireccion.Text.Trim();
                    cj.TEL_CLIENTE = txtTelefono.Text.Trim();
                    cj.ESTADO_CLIENTE = cbxEstadoCliJur.Checked;
                    // Llamar a la función InsertarCliente
                    logClienteJuridico.Instancia.InsertaClienteJuridico(cj);
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
            //MODIFICAR CLIENTE NATURAL
            if (txtRUC.Text.Equals("") || txtRazonSocial.Text.Equals("") || txtTelefono.Text.Equals("") || txtDireccion.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                entClienteJuridico cliente = new entClienteJuridico();
                cliente.ID_CLIENTE = Convert.ToInt32(txtIDCliente.Text);
                cliente.RUC_CLIENTE = txtRUC.Text;
                cliente.RAZON_SOCIAL = txtRazonSocial.Text;
                cliente.DIRECCION = txtDireccion.Text;
                cliente.DEPARTAMENTO = txtDireccion.Text;
                cliente.PROVINCIA = txtDireccion.Text;
                cliente.DISTRITO = txtDireccion.Text;
                cliente.TEL_CLIENTE = txtTelefono.Text;
                cliente.ESTADO_CLIENTE = cbxEstadoCliJur.Checked;
                logClienteJuridico.Instancia.EditaClienteJuridico(cliente);
                MessageBox.Show("Cliente modificado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarClienteJuridico();
                LimpiarVariables();
                gbClienteJuridico.Enabled = false;
            }
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
            try
            {
                DataGridViewRow filaActual = dgvClienteJuridico.Rows[e.RowIndex];
                txtIDCliente.Text = filaActual.Cells[6].Value.ToString();
                txtRUC.Text = filaActual.Cells[0].Value.ToString();
                txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
                txtDireccion.Text = filaActual.Cells[2].Value.ToString();
                txtDepartamento.Text = filaActual.Cells[3].Value.ToString();
                txtProvincia.Text = filaActual.Cells[4].Value.ToString();
                txtDistrito.Text = filaActual.Cells[5].Value.ToString();
                txtTelefono.Text = filaActual.Cells[7].Value.ToString();
                cbxEstadoCliJur.Checked = Convert.ToBoolean(filaActual.Cells[8].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }    
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarCliJur_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRucBuscar.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar un DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entClienteJuridico cliente = new entClienteJuridico();
                    cliente.RUC_CLIENTE = txtRucBuscar.Text;
                    dgvClienteJuridico.DataSource = logClienteJuridico.Instancia.BuscarDniClienteJuridico(cliente);
                    if (dgvClienteJuridico.Rows.Count == 0)
                    {
                        MessageBox.Show("El cliente no se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClienteJuridico();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void txtRucBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtRucBuscar.Text == "")
            {
                ListarClienteJuridico();
            }
        }

        private void btnBuscarClienteJuridicoReniec_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRucBuscar.Text.Length == 11)
                {
                    entDatosRuc respuesta = logDniRuc.ObtenerDatosRUC(txtRucBuscar.Text);
                    txtRazonSocial.Text = respuesta.RazonSocial;
                    txtDireccion.Text = respuesta.Direccion;
                    txtProvincia.Text = respuesta.Provincia;
                    txtDistrito.Text = respuesta.Distrito;
                    txtDepartamento.Text = respuesta.Departamento;
                    txtRUC.Text = respuesta.RUC;
                }
                else
                {
                    MessageBox.Show("El número de RUC debe tener 11 caracteres.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

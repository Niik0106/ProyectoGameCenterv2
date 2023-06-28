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
using LogicaNegocio;
using Entidades;

namespace ProyectoGameCenter
{
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
            ListarProveedor();
            gbProveedor.Enabled = false;
        }

        public void ListarProveedor()
        {
            dgvProveedores.DataSource = logProveedor.Instancia.ListaProveedor();
        }

        private void LimpiarVariables()
        {
            txtIDProveedor.Text = "";
            txtRuc.Text = "";
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
            txtCodigoUbigeo.Text = "";
            txtDepartamento.Text = "";
            txtProvincia.Text = "";
            txtDistrito.Text = "";
            txtNumeroCuenta.Text = "";
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbProveedor.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariables();
            txtRuc.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbProveedor.Enabled =false;
            btnModificar.Visible=true;
            btnAgregar.Visible = true;
            LimpiarVariables();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbProveedor.Enabled=true;
            btnAgregar.Visible=false;
            btnModificar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor pv = new entProveedor();
                pv.RUC_PROV = txtRuc.Text.Trim();
                pv.RAZON_SOCIAL_PROV = txtRazonSocial.Text.Trim();
                pv.TEL_PROVEEDOR = txtTelefono.Text.Trim();
                pv.COD_UBIGEO = int.Parse(txtCodigoUbigeo.Text.Trim());
                pv.DIR_PROVEEDOR = txtDireccion.Text.Trim();
                pv.NUM_CUENTA = txtNumeroCuenta.Text.Trim();
                pv.ESTADO_PROVEEDOR = cbxEstadoProv.Checked;
                // Llamar a la función InsertarCliente
                Boolean insertado = logProveedor.Instancia.InsertaProveedor(pv);

                if (insertado)
                {
                    MessageBox.Show("El Proveedor se agregó exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            gbProveedor.Enabled = false;
            ListarProveedor();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor pv = new entProveedor();
                pv.ID_PROVEEDOR = int.Parse(txtIDProveedor.Text.Trim());
                pv.RUC_PROV = txtRuc.Text.Trim();
                pv.RAZON_SOCIAL_PROV = txtRazonSocial.Text.Trim();
                pv.TEL_PROVEEDOR = txtTelefono.Text.Trim();
                pv.COD_UBIGEO = int.Parse(txtCodigoUbigeo.Text.Trim());
                pv.DIR_PROVEEDOR = txtDireccion.Text.Trim();
                pv.NUM_CUENTA = txtNumeroCuenta.Text.Trim();
                pv.ESTADO_PROVEEDOR = cbxEstadoProv.Checked;
                // Llamar a la función InsertarCliente
                Boolean editado = logProveedor.Instancia.InsertaProveedor(pv);

                if (editado)
                {
                    MessageBox.Show("El Proveedor se Modifico exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            gbProveedor.Enabled = false;
            ListarProveedor();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvProveedores.Rows[e.RowIndex];
                txtIDProveedor.Text = filaActual.Cells[0].Value.ToString();
                txtRuc.Text = filaActual.Cells[1].Value.ToString();
                txtRazonSocial.Text = filaActual.Cells[2].Value.ToString();
                txtTelefono.Text = filaActual.Cells[3].Value.ToString();
                txtCodigoUbigeo.Text = filaActual.Cells[4].Value.ToString();
                txtDireccion.Text = filaActual.Cells[5].Value.ToString();
                txtNumeroCuenta.Text = filaActual.Cells[6].Value.ToString();
                cbxEstadoProv.Checked = Convert.ToBoolean(filaActual.Cells[7].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }     
        }

        private void btnInhabilitarProv_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor pv = new entProveedor();
                pv.ID_PROVEEDOR = int.Parse(txtIDProveedor.Text.Trim());
                cbxEstadoProv.Checked = false;
                pv.ESTADO_PROVEEDOR = cbxEstadoProv.Checked;
                logProveedor.Instancia.InhabilitaProveedor(pv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbProveedor.Enabled = false;
            ListarProveedor();
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {

        }
    }
}

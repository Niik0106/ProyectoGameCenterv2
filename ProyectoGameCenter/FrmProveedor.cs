using System;
using Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using System.Data.SqlClient;
using System.Windows.Markup.Localizer;
using AccesoDatos;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using System.Windows.Media;
using System.IO;
using System.Net;

namespace ProyectoGameCenter
{
    public partial class FrmProveedor : Form
    {
        private logDniRuc logDniRuc;
        public FrmProveedor()
        {
            InitializeComponent();
            ListarProveedor();
            gbProveedor.Enabled = false;
            logDniRuc = new logDniRuc();
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
            //txtNumeroCuenta.Text = "";
            
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
                if (txtRuc.Text.Equals("") | txtRazonSocial.Text.Equals("") | txtTelefono.Text.Equals("") |
                    txtDireccion.Text.Equals("") | txtCodigoUbigeo.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entProveedor pv = new entProveedor();
                    pv.RUC_PROV = txtRuc.Text.Trim();
                    pv.RAZON_SOCIAL_PROV = txtRazonSocial.Text.Trim();
                    pv.TEL_PROVEEDOR = txtTelefono.Text.Trim();
                    pv.COD_UBIGEO = int.Parse(txtCodigoUbigeo.Text.Trim());
                    pv.DIR_PROVEEDOR = txtDireccion.Text.Trim();
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
                cbxEstadoProv.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla", ex.Message);
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

        private void btnBuscarRucApi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRuc.Text.Length == 11)
                {
                    entDatosRuc respuesta = logDniRuc.ObtenerDatosRUC(txtRuc.Text);
                    txtRazonSocial.Text = respuesta.RazonSocial;
                    txtDireccion.Text = respuesta.Direccion;
                    txtProvincia.Text = respuesta.Provincia;
                    txtDistrito.Text = respuesta.Distrito;
                    txtDepartamento.Text = respuesta.Departamento;
                    txtRuc.Text = respuesta.RUC;
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

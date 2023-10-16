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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            gbUsuarios.Enabled = false;
            txtIDUsuario.Enabled = false;
            ListarUsuarios();
            LlenarDatosRol();
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AllowUserToResizeColumns = false;
            foreach (DataGridViewColumn column in dgvUsuarios.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
            // Crear una instancia de RoundedTextBox
            RoundedTextBox roundedTextBox1 = new RoundedTextBox();
            roundedTextBox1.Location = new Point(50, 50);
            roundedTextBox1.Size = new Size(200, 30);

            // Agregar el RoundedTextBox al formulario
            this.Controls.Add(roundedTextBox1);
        }

        public void ListarUsuarios()
        {
            dgvUsuarios.DataSource = logUsuarios.Instancia.ListarUsuario();
        }

        public void LlenarDatosRol()
        {
            cboRol.DataSource = logUsuarios.Instancia.ListarRol();
            cboRol.DisplayMember = "NombreRol";
            cboRol.ValueMember = "IdRol";
        }

        private void LimpiarVariables()
        {
            txtIDUsuario.Clear();
            txtNombreUsuario.Clear();
            cboRol.SelectedValue = 0;
            txtUsuario.Clear();
            txtContrasenia.Clear();
            txtBuscarUsuario.Clear();
            cboEstadoUsuario.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreUsuario.Text.Equals("") | txtUsuario.Text.Equals("") |
                    txtContrasenia.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entUsuarios c = new entUsuarios();
                    c.Nombres = txtNombreUsuario.Text.Trim();
                    c.Usuario = txtUsuario.Text.Trim();
                    c.Clave = txtContrasenia.Text.Trim();
                    c.IdUsuario = Convert.ToInt32(txtIDUsuario);
                    c.IdRol = Convert.ToInt32(cboRol.SelectedValue);
                    c.estado = cboEstadoUsuario.Checked;
                    logUsuarios.Instancia.InsertaUsuario(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbUsuarios.Enabled = false;
            ListarUsuarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                    entUsuarios c = new entUsuarios();
                    c.Nombres = txtNombreUsuario.Text.Trim();
                    c.Usuario = txtUsuario.Text.Trim();
                    c.Clave = txtContrasenia.Text.Trim();
                    c.IdUsuario = Convert.ToInt32(txtIDUsuario);
                    c.IdRol = Convert.ToInt32(cboRol.SelectedValue);
                    c.estado = cboEstadoUsuario.Checked;
                    logUsuarios.Instancia.EditaUsuarios(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbUsuarios.Enabled = false;
            ListarUsuarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbUsuarios.Enabled = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            LimpiarVariables();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbUsuarios.Enabled = true;
            btnModificar.Visible = false;
            btnAgregar.Visible = true;
            LimpiarVariables();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbUsuarios.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count > 0)
                {
                    entUsuarios c = new entUsuarios();
                    c.IdUsuario = int.Parse(txtIDUsuario.Text.Trim());
                    logUsuarios.Instancia.DeshabilitarUsuario(c);
                }
                else
                {
                    MessageBox.Show("Escoge un elemento primero");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbUsuarios.Enabled = false;
            ListarUsuarios();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (txtBuscarUsuario.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar el nombre de un Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entUsuarios usuario = new entUsuarios();
                    usuario.Nombres = txtBuscarUsuario.Text;
                    dgvProductos.DataSource = logProducto.Instancia.BuscaDescProducto(producto);
                    if (dgvProductos.Rows.Count == 0)
                    {
                        MessageBox.Show("El Producto no se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarProductos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Entidades;

namespace ProyectoGameCenter
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            ListarCategoria();
        }

        public void ListarCategoria()
        {
            dgvCategoria.DataSource = logCategoria.Instancia.ListarCategoria();
        }

        private void LimpiarVariables()
        {
            txtIDCategoria.Clear();
            txtDescripcionCategoria.Clear();
            cbxEstadoCate.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbCategoria.Enabled = true;
            LimpiarVariables();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbCategoria.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnDeshabilitarCate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoria.SelectedRows.Count > 0)
                {
                    entCategoria c = new entCategoria();
                    c.idCategoria = int.Parse(txtIDCategoria.Text.Trim());
                    logCategoria.Instancia.DeshabilitarCiudad(c);          
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
            gbCategoria.Enabled = false;
            ListarCategoria();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria c = new entCategoria();
                c.desCategoria = txtDescripcionCategoria.Text.Trim();
                c.estCategoria = cbxEstadoCate.Checked;
                logCategoria.Instancia.InsertaCategoria(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbCategoria.Enabled = false;
            ListarCategoria();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria c = new entCategoria();
                c.idCategoria = int.Parse(txtIDCategoria.Text.Trim());
                c.desCategoria = txtDescripcionCategoria.Text.Trim();
                c.estCategoria = cbxEstadoCate.Checked;
                logCategoria.Instancia.EditaCategoria(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbCategoria.Enabled = false;
            ListarCategoria();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbCategoria.Enabled = false;
            LimpiarVariables();
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvCategoria.Rows[e.RowIndex];
                txtIDCategoria.Text = filaActual.Cells[0].Value.ToString();
                txtDescripcionCategoria.Text = filaActual.Cells[1].Value.ToString();
                cbxEstadoCate.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No toques", ex.Message);
            }

        }
    }
}

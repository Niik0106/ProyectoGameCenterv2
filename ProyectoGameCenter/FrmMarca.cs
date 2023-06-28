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
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
            gbMarca.Enabled = false;
            txtIDMarca.Enabled = false;
            ListarMarcas();
        }

        public void ListarMarcas()
        {
            dgvMarca.DataSource = logMarca.Instancia.ListarMarca();
        }

        public void LimpiarVariables()
        {
            txtIDMarca.Text = "";
            txtDescripcionMarca.Text = "";
            cbxEstadoMarca.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbMarca.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariables();
            txtDescripcionMarca.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbMarca.Enabled = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbMarca.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcionMarca.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entMarca marca = new entMarca();
                    marca.desMarca = txtDescripcionMarca.Text.Trim();
                    marca.estMarca = cbxEstadoMarca.Checked;
                    logMarca.Instancia.InsertaMarca(marca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMarca.Enabled = false;
            ListarMarcas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca Marca = new entMarca();
                Marca.idMarca = int.Parse(txtIDMarca.Text.Trim());
                Marca.desMarca = txtDescripcionMarca.Text.Trim();
                Marca.estMarca = cbxEstadoMarca.Checked;
                logMarca.Instancia.EditaMarca(Marca);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMarca.Enabled = false;
            ListarMarcas();
        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvMarca.Rows[e.RowIndex];
                txtIDMarca.Text = filaActual.Cells[0].Value.ToString();
                txtDescripcionMarca.Text = filaActual.Cells[1].Value.ToString();
                cbxEstadoMarca.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }
        }

        private void btnDeshabilitarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca Marca = new entMarca();
                Marca.idMarca = int.Parse(txtIDMarca.Text.Trim());
                cbxEstadoMarca.Checked = false;
                Marca.estMarca =cbxEstadoMarca.Checked;
                logMarca.Instancia.DeshabilitaMarca(Marca);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbMarca.Enabled = false;
            ListarMarcas();
        }
    }
}

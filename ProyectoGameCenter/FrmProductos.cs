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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
            
            gbProductos.Enabled = false;
            txtIDProducto.Enabled = false;
            LlenarDatosCategoria();
        }

        public void LlenarDatosCategoria()
        {
            cboCategoria.DataSource = logCategoria.Instancia.ListarCategoria();
            cboCategoria.DisplayMember = "desCategoria";
            cboCategoria.ValueMember = "idCategoria";
        }

        public void LlenarDatosMarca()
        {
            cboMarca.DataSource = logMarca.Instancia.ListarMarca();
            cboMarca.DisplayMember = "desMarca";
            cboMarca.ValueMember = "idMarca";
        }

        private void LimpiarVariables()
        {
            txtBuscarProducto.Clear();
            txtBuscarProducto.Clear();
            cbxEstadoProd.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto c = new entProducto();
                c.desProducto = txtBuscarProducto.Text.Trim();
                c.estProducto = cbxEstadoProd.Checked;
                c.idCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                c.idMarca = Convert.ToInt32(cboMarca.SelectedValue);
                logProducto.Instancia.InsertaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbProductos.Enabled = false;
            LlenarDatosCategoria();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeshabilitarProd_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}

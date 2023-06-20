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
            ListarProductos();
            LlenarDatosCategoria();
            LlenarDatosMarca();
        }

        public void ListarProductos()
        {
            dgvProductos.DataSource = logProducto.Instancia.ListaProducto();
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
            txtIDProducto.Clear();
            txtDescripcionProducto.Clear();
            cboCategoria.SelectedValue = 0;
            cboMarca.SelectedValue = 0;
            txtPrecio.Clear();
            txtStock.Clear();
            txtBuscarProducto.Clear();
            cbxEstadoProd.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto c = new entProducto();
                c.desProducto = txtDescripcionProducto.Text.Trim();
                c.idCategoria = Convert.ToInt32(cboMarca.SelectedValue);
                c.idMarca = Convert.ToInt32(cboMarca.SelectedValue);
                c.precioProd = decimal.Parse(txtPrecio.Text.Trim());
                c.stockProd = int.Parse(txtStock.Text.Trim());
                c.estProducto = cbxEstadoProd.Checked;
                logProducto.Instancia.InsertaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbProductos.Enabled = false;
            ListarProductos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto c = new entProducto();
                c.idProducto = int.Parse(txtIDProducto.Text.Trim());
                c.desProducto = txtDescripcionProducto.Text.Trim();
                c.idCategoria = Convert.ToInt32(cboMarca.SelectedValue);
                c.idMarca = Convert.ToInt32(cboMarca.SelectedValue);
                c.precioProd = decimal.Parse(txtPrecio.Text.Trim());
                c.stockProd = int.Parse(txtStock.Text.Trim());
                c.estProducto = cbxEstadoProd.Checked;
                logProducto.Instancia.EditaProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbProductos.Enabled = false;
            ListarProductos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbProductos.Enabled = false;
            LimpiarVariables();
        }

        private void btnDeshabilitarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    entProducto c = new entProducto();
                    c.idProducto = int.Parse(txtIDProducto.Text.Trim());
                    logProducto.Instancia.DeshabilitarProducto(c);
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
            gbProductos.Enabled = false;
            ListarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbProductos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbProductos.Enabled = true;
            LimpiarVariables();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            txtIDProducto.Focus();
            string desProd = txtDescripcionProducto.Text;
            entProducto Prod = logProducto.Instancia.BuscarProducto(desProd);

            if(Prod != null && (Prod.estProducto= true))
            {
                txtIDProducto.Text = Convert.ToString(Prod.idProducto);
                txtPrecio.Text = Convert.ToString(Prod.precioProd);
                txtStock.Text = Convert.ToString(Prod.stockProd);
            }
            else
            {
                MessageBox.Show("El producto no existe o esta inhabilitado. Verfique nuevamente");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProductos.Rows[e.RowIndex];
            txtIDProducto.Text = filaActual.Cells[0].Value.ToString();
            txtDescripcionProducto.Text = filaActual.Cells[1].Value.ToString();
            cboCategoria.Text = filaActual.Cells[2].Value.ToString();
            cboMarca.Text = filaActual.Cells[3].Value.ToString();
            txtPrecio.Text = filaActual.Cells[4].Value.ToString();
            txtStock.Text = filaActual.Cells[5].Value.ToString();
            cbxEstadoProd.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }
    }
}

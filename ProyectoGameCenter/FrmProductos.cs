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
                if (txtDescripcionProducto.Text.Equals("") | txtPrecio.Text.Equals("") |
                    txtStock.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entProducto c = new entProducto();
                    c.desProducto = txtDescripcionProducto.Text.Trim();
                    c.idCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                    c.idMarca = Convert.ToInt32(cboMarca.SelectedValue);
                    c.precioProd = decimal.Parse(txtPrecio.Text.Trim());
                    c.stockProd = int.Parse(txtStock.Text.Trim());
                    c.estProducto = cbxEstadoProd.Checked;
                    logProducto.Instancia.InsertaProducto(c);
                }
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
                c.idCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
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
            btnAgregar.Visible= true;
            btnModificar.Visible = true;
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
            btnModificar.Visible = false;
            btnAgregar.Visible = true;
            LimpiarVariables();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarProducto.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar la descripcion de un Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entProducto producto = new entProducto();
                    producto.desProducto = txtBuscarProducto.Text;
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
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvProductos.Rows[e.RowIndex];
                txtIDProducto.Text = filaActual.Cells[0].Value.ToString();
                txtDescripcionProducto.Text = filaActual.Cells[1].Value.ToString();
                cboCategoria.SelectedIndex = Convert.ToInt32(filaActual.Cells[2].Value);
                cboMarca.SelectedIndex = Convert.ToInt32(filaActual.Cells[3].Value);
                txtPrecio.Text = filaActual.Cells[4].Value.ToString();
                txtStock.Text = filaActual.Cells[5].Value.ToString();
                cbxEstadoProd.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }
            
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscarProducto.Text == "")
            {
                dgvProductos.DataSource = logProducto.Instancia.ListaProducto();
            }
        }
    }
}

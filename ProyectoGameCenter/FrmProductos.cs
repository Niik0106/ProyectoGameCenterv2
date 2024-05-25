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
using ClosedXML;
using ClosedXML.Excel;

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
            dgvProductos.AllowUserToResizeRows = false; 
            dgvProductos.AllowUserToResizeColumns = false;
            foreach (DataGridViewColumn column in dgvProductos.Columns)
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

        private void ExportarDatosAExcel()
        {
            // Crear un DataTable y agregar las columnas necesarias
            DataTable dt = new DataTable();
            dt.Columns.Add("DES_PRODUCTO");
            dt.Columns.Add("DES_CATEGORIA");
            dt.Columns.Add("DES_MARCA");
            dt.Columns.Add("PRECIO_COMPRA");
            dt.Columns.Add("PRECIO_VENTA");
            dt.Columns.Add("STOCK");

            // Llenar el DataTable con los datos del DataGridView
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.IsNewRow) continue;
                dt.Rows.Add(
                    row.Cells["DES_PRODUCTO"].Value,
                    row.Cells["DES_CATEGORIA"].Value,
                    row.Cells["DES_MARCA"].Value,
                    row.Cells["PRECIO_COMPRA"].Value,
                    row.Cells["PRECIO_VENTA"].Value,
                    row.Cells["STOCK"].Value
                );
            }

            // Crear un nuevo archivo Excel y agregar los datos del DataTable
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Productos");

                // Guardar el archivo Excel en una ubicación específica
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Guardar archivo Excel";
                saveFileDialog.FileName = "Productos.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados exitosamente.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
            txtPrecioVenta.Clear();
            txtStock.Clear();
            txtBuscarProducto.Clear();
            cbxEstadoProd.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcionProducto.Text.Equals("") | txtPrecioVenta.Text.Equals("") |
                    txtStock.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entProducto c = new entProducto();
                    c.DES_PRODUCTO = txtDescripcionProducto.Text.Trim();
                    c.ID_CATEGORIA = Convert.ToInt32(cboCategoria.SelectedValue);
                    c.ID_MARCA = Convert.ToInt32(cboMarca.SelectedValue);
                    c.PRECIO_VENTA = decimal.Parse(txtPrecioVenta.Text.Trim());
                    c.PRECIO_COMPRA = decimal.Parse(txtPrecioVenta.Text.Trim());
                    c.STOCK = int.Parse(txtStock.Text.Trim());
                    c.ESTADO_PRODUCTO = cbxEstadoProd.Checked;
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
                c.ID_PRODUCTO = int.Parse(txtIDProducto.Text.Trim());
                c.DES_PRODUCTO = txtDescripcionProducto.Text.Trim();
                c.ID_CATEGORIA = Convert.ToInt32(cboCategoria.SelectedValue);
                c.ID_MARCA = Convert.ToInt32(cboMarca.SelectedValue);
                c.PRECIO_VENTA = decimal.Parse(txtPrecioVenta.Text.Trim());
                c.PRECIO_COMPRA = decimal.Parse(txtPrecioVenta.Text.Trim());
                c.STOCK = int.Parse(txtStock.Text.Trim());
                c.ESTADO_PRODUCTO = cbxEstadoProd.Checked;
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
                    c.ID_PRODUCTO = int.Parse(txtIDProducto.Text.Trim());
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
                    producto.DES_PRODUCTO = txtBuscarProducto.Text;
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
                cboCategoria.SelectedValue = Convert.ToInt32(filaActual.Cells[7].Value);
                cboMarca.SelectedValue = Convert.ToInt32(filaActual.Cells[8].Value);
                txtPrecioVenta.Text = filaActual.Cells[5].Value.ToString();
                txtPrecioCompra.Text = filaActual.Cells[4].Value.ToString();
                txtStock.Text = filaActual.Cells[6].Value.ToString();
                cbxEstadoProd.Checked = Convert.ToBoolean(filaActual.Cells[9].Value);
            }catch (Exception ex)
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

        private void cbxEstadoProd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //AjustarDatagrindviewHeight();
        }

        private void AjustarDatagrindviewHeight()
        {
            var height = dgvProductos.ColumnHeadersHeight;
            foreach(DataGridViewRow dr in dgvProductos.Rows)
            {
                height+= dr.Height;

            }
            dgvProductos.Height = height;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel();
        }
    }
}

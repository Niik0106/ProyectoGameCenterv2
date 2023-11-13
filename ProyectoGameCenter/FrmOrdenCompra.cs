using AccesoDatos;
using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGameCenter
{
    public partial class FrmOrdenCompra : Form

    {
        private decimal total = 0;
        public FrmOrdenCompra()
        {
            InitializeComponent();
            LlenarDatosEstadoOrdenVenta();
            ListadoOrdenesCompra();
            gboOrdenCompra.Enabled = false;
            gbDetalleOrdenCompra.Enabled = false;
        }

        public void LlenarDatosEstadoOrdenVenta()
        {
            cbxEstadoCompra.DataSource = logEstadoOrdenCompra.Instancia.ListaEstadoOrdenCompra();
            cbxEstadoCompra.DisplayMember = "DES_ESTADO_OC";
            cbxEstadoCompra.ValueMember = "ID_EST_ORDEN_COMPRA";
        }
        private void ListadoOrdenesCompra()
        {
            dgvOrdenCompra.DataSource = logOrdenCompra.Instancia.ListarOrdenesCompra();
        }
        private void ListadoDetalleOrdenesCompra()
        {
            dgvDetalleOrdenCompra.DataSource = logDetalleOrdenCompra.Instancia.ListarDetalleOrdenCompra();
        }

        public void LimpiarVariables()
        {
            txtIDOrdenCompra.Text = "";
            dtpFOrdenCompra.ResetText();
            txtRazonSocial.Text = "";
            txtRucProveedor.Text = "";
            cbxEstadoCompra.SelectedIndex = default;
        }

        public void LimpiarVariablesDetalleCompra()
        {
            txtDesProducto.Text = "";
            txtIDProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecioCompra.Text = "";
            txtTotalCompra.Text = "";
        }

        public void LimpiarVariablesDetalle()
        {
            txtDesProducto.Text = "";
            txtIDProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecioCompra.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRucProveedor.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar la descripcion de un Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entOrdenCompra ordCompra = new entOrdenCompra();
                    //ordCompra.numeroOrdenCompra = Convert.ToInt32(txtNumOrdenCompra.Text.Trim());
                    ordCompra.fechaOrdenCompra = dtpFOrdenCompra.Value;
                    //ordCompra.razonSocial = txtRazonSocial.Text.Trim();
                    ordCompra.idEstadoOrdenCompra = Convert.ToInt32(cbxEstadoCompra.SelectedValue);
                    ordCompra.RUC = txtRucProveedor.Text.Trim();
                    logOrdenCompra.Instancia.InsertarOrdenCompra(ordCompra);
                    gbDetalleOrdenCompra.Enabled = true;

                    MessageBox.Show("Orden de Compra registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gboOrdenCompra.Enabled = false;
            gbDetalleOrdenCompra.Enabled= true;
            ListadoOrdenesCompra();
        }

        //private void btnBuscarProducto_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //Buscar Producto
        //        entProducto producto = new entProducto();
        //        producto = logProducto.Instancia.BuscarIDProducto(Convert.ToInt32(txtIDProducto.Text.Trim()));
        //        if (producto != null)
        //        {
        //            txtDesProducto.Text = producto.DES_PRODUCTO.ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Producto no existe en la BD", "Buscar Provducto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error.." + ex);
        //    }

        //}

        private void btnBuscaridProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor proveedor = new entProveedor();
                proveedor = logProveedor.Instancia.BuscarIDProveedor(Convert.ToInt32(txtRucProveedor.Text.Trim()));
                if (proveedor != null)
                {
                    txtRazonSocial.Text = proveedor.RAZON_SOCIAL_PROV.ToString();
                }
                else
                {
                    MessageBox.Show("Proveedor no esta Catalogado", "Buscar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }
            //Buscar Proveedor
           

        
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            //Insertar Detalle orden compra
            try
            {
                entDetalleOrdenCompra detOrdenCompra = new entDetalleOrdenCompra();
                detOrdenCompra.NumOrdenCompra = Convert.ToInt32(txtNumOrdenCompra.Text.Trim());
                detOrdenCompra.IDProducto = Convert.ToInt32(txtIDProducto.Text.Trim());
                detOrdenCompra.Descripcion = txtDesProducto.Text.Trim();
                detOrdenCompra.cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
                detOrdenCompra.PrecioCompra = decimal.Parse(txtPrecioCompra.Text.Trim());
                detOrdenCompra.Total = int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioCompra.Text);

                // Llamar a la función InsertarCliente
                Boolean insertado = logDetalleOrdenCompra.Instancia.InsertarDetalleOrdenCompra(detOrdenCompra);

                if (insertado)
                {
                    MessageBox.Show("El Producto se agregó exitosamente al DETALLE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    total = total + (int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioCompra.Text));                    
                    txtTotalCompra.Text = total.ToString();
                    detOrdenCompra.NumOrdenCompra = Convert.ToInt32(txtNumOrdenCompra.Text.Trim());
                    dgvDetalleOrdenCompra.DataSource = logDetalleOrdenCompra.Instancia.OrdenaDetalleCompra(detOrdenCompra);
                    if (dgvDetalleOrdenCompra.Rows.Count == 0)
                    {
                        MessageBox.Show("Hola ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LimpiarVariablesDetalle();
                    ListadoDetalleOrdenesCompra();
                }
                else
                {
                    MessageBox.Show("YA EXISTE UN DETALLE CON ESE NUM ORDEN DE COMPRA E ID PRODUCTO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error.." + ex);
            }
            ListadoDetalleOrdenesCompra();
        }



        private void btnBuscarOC_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenCompra OrdC = new entOrdenCompra();
                OrdC.fechaOrdenCompra = dtpBuscarFecha.Value;
                dgvOrdenCompra.DataSource = logOrdenCompra.Instancia.BuscaFechaCompra(OrdC);
                if (dgvOrdenCompra.Rows.Count == 0)
                {
                    MessageBox.Show("NO existen ventas de esta fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListadoOrdenesCompra();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrdenCompra.SelectedRows.Count > 0)
                {
                    entOrdenCompra c = new entOrdenCompra();
                    c.idOrdenCompra = int.Parse(txtIDOrdenCompra.Text.Trim());
                    logOrdenCompra.Instancia.AnulaOrdenCompra(c);
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
            txtNumOrdenCompra.Text = "";
            ListadoOrdenesCompra();
        }

        private void dgvOrdenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvOrdenCompra.Rows[e.RowIndex];
                int numOrdenCompra = Convert.ToInt32(dgvOrdenCompra.Rows[e.RowIndex].Cells[1].Value);
                txtIDOrdenCompra.Text = filaActual.Cells[0].Value.ToString();
                txtNumOrdenCompra.Text = filaActual.Cells[1].Value.ToString();
                dtpFOrdenCompra.Text = filaActual.Cells[2].Value.ToString();
                txtRucProveedor.Text = filaActual.Cells[6].Value.ToString();
                txtRazonSocial.Text = filaActual.Cells[4].Value.ToString();
                cbxEstadoCompra.SelectedValue = Convert.ToInt32(filaActual.Cells[5].Value);
                entDetalleOrdenCompra DOC = new entDetalleOrdenCompra();
                DOC.NumOrdenCompra = numOrdenCompra;
                dgvDetalleOrdenCompra.DataSource = logDetalleOrdenCompra.Instancia.OrdenaDetalleCompra(DOC);
                entPagoCompra compra = new entPagoCompra();
                compra = logPagoCompra.Instancia.ObtenerDetallePago(int.Parse(txtNumOrdenCompra.Text.ToString()));
                if (compra != null)
                {
                    txtTotalCompra.Text = compra.TOTAL.ToString();

                }
                else
                {
                    MessageBox.Show("Monto TOTAL no existe", "Click en Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }
                                   
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gboOrdenCompra.Enabled = true;
            LimpiarVariables();
            dgvDetalleOrdenCompra.DataSource = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmOrdenCompra_Load(object sender, EventArgs e)
        {

        }


        private void gbDetalleOrdenCompra_Enter(object sender, EventArgs e)
        {

        }

       

        private void dgvDetalleOrdenCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvDetalleOrdenCompra.Rows[e.RowIndex];
                txtIDProducto.Text = filaActual.Cells[0].Value.ToString();
                txtDesProducto.Text = filaActual.Cells[1].Value.ToString();
                txtPrecioCompra.Text = Convert.ToString(filaActual.Cells[5].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }
        }

        private void txtDesProducto__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDesProducto.Text.Equals(""))
                {
                    ListadoDetalleOrdenesCompra();
                    txtIDProducto.Text = "";
                    txtPrecioCompra.Text = "";
                    txtCantidad.Text = "";

                }
                else
                {
                    entProducto producto = new entProducto();
                    producto.DES_PRODUCTO = txtDesProducto.Text;
                    dgvDetalleOrdenCompra.DataSource = logProducto.Instancia.BuscaDescProducto(producto);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalCompra.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entPagoCompra c = new entPagoCompra();
                    c.NUM_ORDEN_COMPRA = Convert.ToInt32(txtNumOrdenCompra.Text.Trim());
                    c.TOTAL = decimal.Parse(txtTotalCompra.Text.Trim());
                    logPagoCompra.Instancia.InsertarPago(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            LimpiarVariablesDetalleCompra();
            gbDetalleOrdenCompra.Enabled = false;
            gboOrdenCompra.Enabled = false;
            ListadoOrdenesCompra();
        }
    }
}

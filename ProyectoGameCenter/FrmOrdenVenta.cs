using Entidades;
using System;
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

namespace ProyectoGameCenter
{
    public partial class FrmOrdenVenta : Form
    {
        private logCliente clienteLogic;
        private decimal total = 0;
        private decimal Subtotal = 0;
        private double igv = 0;
        public static string nOrdenVenta;
        public static string totalCR;
        public static string idCliente;
        public FrmOrdenVenta()
        {
            
            InitializeComponent();  
            LlenarDatosEstadoOrdenVenta();
            ListarVentas();
            LlenarDatosTipoComprobante();
            LlenarDatosMetodoPago();
            LlenarDatosTipoPago();
            clienteLogic = new logCliente();

        }

        public void ListarVentas()
        {
            dgvOrdenVenta.DataSource = logOrdenVenta.Instancia.ListarVentas();
        }


        public void ListarDetalleVentas()
        {
            dgvDetalleOrdenVenta.DataSource = logDetalleOrdenVenta.Instancia.ListarDetalleOrdenVenta();
        }

        public void LlenarDatosEstadoOrdenVenta()
        {
            cboEstado.DataSource = logEstadoOrdenVenta.Instancia.ListaEstadoOrdenVenta();
            cboEstado.DisplayMember = "DES_ESTADO_OV";
            cboEstado.ValueMember = "ID_EST_ORDEN_VENTA";
        }

        public void LlenarDatosMetodoPago()
        {
            cboMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
            cboMetodoPago.DisplayMember = "DES_METODO_PAGO";
            cboMetodoPago.ValueMember = "ID_METODO_PAGO";
        }

        public void LlenarDatosTipoPago()
        {
            cboTipoPago.DataSource = logTipoPago.Instancia.ListarTipoPago();
            cboTipoPago.DisplayMember = "DES_TIPO_PAGO";
            cboTipoPago.ValueMember = "ID_TIPO_PAGO";
        }

        public void LlenarDatosTipoComprobante()
        {
            cboTipoComprobante.DataSource = logTipoComprobante.Instancia.ListarTipoComprobante();
            cboTipoComprobante.DisplayMember = "DES_TIPO_COMPROBANTE";
            cboTipoComprobante.ValueMember = "ID_TIPO_COMPROBANTE";
        }

        public void LimpiarVariables()
        {
            txtIDOrdenVenta.Text = "";
            dateTimePicker1.ResetText();
            txtResultadoBusquedaCliente.Text = "";
            
            cboEstado.SelectedIndex = default;
            gbOrdenVenta.Enabled = false;
        }

        public void LimpiarImportes()
        {
            txtSubTotal.Text = "";
            txtIgv.Text = "";
            txtTotal.Text = "";
            cboMetodoPago.SelectedIndex = default;
            cboTipoPago.SelectedIndex = default;
            gbImportes.Enabled = false;
        }

        public void LimpiarVariablesDetalle()
        {
            txtIDProducto.Text = "";
            txtDesProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecioVenta.Text = "";
          
            txtStock.Text = "";
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Busca Producto
                entProducto entProducto = new entProducto();
                entProducto = logProducto.Instancia.BuscarProducto(txtDesProducto.Text.ToString());
                if (entProducto != null)
                {
                    txtDesProducto.Text = entProducto.DES_PRODUCTO.ToString();
                    txtIDProducto.Text = entProducto.ID_PRODUCTO.ToString();
                    txtStock.Text = entProducto.STOCK.ToString();
                    txtPrecioVenta.Text = entProducto.PRECIO_VENTA.ToString();
                    txtPrecioCompra.Text = entProducto.PRECIO_COMPRA.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no existe", "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

        }

        private void btnBuscaridCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(txtDocumentoCliente.Text);

                string identificacion = clienteLogic.ObtenerIdentificacionClientePorID(idCliente);

                if (!string.IsNullOrEmpty(identificacion))
                {
                    txtResultadoBusquedaCliente.Text = identificacion;
                }
                else
                {
                    txtResultadoBusquedaCliente.Text = "No se encontró el cliente.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente no existe");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbOrdenVenta.Enabled = true;
            gbDetalleOrdenVenta.Enabled=true;
            LimpiarVariables();
            LimpiarVariablesDetalle();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrdenVenta.SelectedRows.Count > 0)
                {
                    entOrdenVenta c = new entOrdenVenta();
                    c.idOrdenVenta = int.Parse(txtIDOrdenVenta.Text.Trim());
                    logOrdenVenta.Instancia.AnulaOrdenVenta(c);
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
            txtNOrdenVenta.Text = "";
            ListarVentas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNOrdenVenta.Text = "";
            LimpiarVariables();
        }

        private void dgvOrdenVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvOrdenVenta.Rows[e.RowIndex];
                string numOrdenVenta = (string)dgvOrdenVenta.Rows[e.RowIndex].Cells[1].Value;
                txtIDOrdenVenta.Text = filaActual.Cells[0].Value.ToString();
                txtNOrdenVenta.Text = filaActual.Cells[1].Value.ToString();
                dateTimePicker1.Text = filaActual.Cells[2].Value.ToString();
                txtDocumentoCliente.Text = filaActual.Cells[5].Value.ToString();
                cboEstado.SelectedValue = Convert.ToInt32(filaActual.Cells[4].Value);
                cboTipoComprobante.SelectedValue = Convert.ToInt32(filaActual.Cells[6].Value);


                entDetalleOrdenVenta DOV = new entDetalleOrdenVenta();
                DOV.NUM_ORDEN_VENTA = numOrdenVenta;
                dgvDetalleOrdenVenta.DataSource = logDetalleOrdenVenta.Instancia.OrdenaDetalleVenta(DOV);
                gbDetalleOrdenVenta.Enabled = true;
                txtIDProducto.Enabled = false;
                txtCantidad.Enabled = true;
                btnAgregarProducto.Enabled = true;
                btnFinalizar.Enabled = true;
                btnBuscarProducto.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un item de la tabla");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                entDetalleOrdenVenta DetalleOV = new entDetalleOrdenVenta();
                DetalleOV.NUM_ORDEN_VENTA = txtNOrdenVenta.Text.Trim();
                DetalleOV.ID_PRODUCTO = int.Parse(txtIDProducto.Text.Trim());
                DetalleOV.DESCRIPCION_PROD = txtDesProducto.Text.Trim();
                DetalleOV.CANTIDAD = int.Parse(txtCantidad.Text.Trim());
                DetalleOV.PRECIO = decimal.Parse(txtPrecioVenta.Text.Trim());
                DetalleOV.PRECIO_TOTAL = int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioVenta.Text);



               
                // Llamar a la función InsertarCliente
                Boolean insertado = logDetalleOrdenVenta.Instancia.InsertaDetalleOrdenVenta(DetalleOV);

                if (insertado)
                {
                    MessageBox.Show("El Producto se agregó exitosamente al DETALLE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Subtotal = Subtotal+(int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioVenta.Text));
                    txtSubTotal.Text = Subtotal.ToString();
                    igv = double.Parse(txtSubTotal.Text) * 0.18;
                    txtIgv.Text = igv.ToString();
                    total = decimal.Parse(txtSubTotal.Text) + decimal.Parse(txtIgv.Text);
                    txtTotal.Text = total.ToString();
                    ListarDetalleVentas();
                    LimpiarVariablesDetalle();
                }
                else
                {
                    MessageBox.Show("No hay STOCK SUFICIENTE de ese PRODUCTO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    LimpiarVariablesDetalle();
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            gbOrdenVenta.Enabled = false;
            gbDetalleOrdenVenta.Enabled=false;
        }

        private void btnCPago_Click(object sender, EventArgs e)
        {
            idCliente = txtDocumentoCliente.Text;
            nOrdenVenta = txtNOrdenVenta.Text;
            totalCR = txtTotal.Text;
            FrmCronogramaPago Cpago = new FrmCronogramaPago();
            Cpago.StartPosition = FormStartPosition.CenterScreen;
            Cpago.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            LimpiarVariablesDetalle();
            txtNOrdenVenta.Clear();
            txtDocumentoCliente.Clear();
            dgvDetalleOrdenVenta.DataSource = null;
            dgvDetalleOrdenVenta.Rows.Clear();
            dgvDetalleOrdenVenta.Columns.Clear();
            //ListarVentas();
            dgvDetalleOrdenVenta.Enabled = false;
            txtIDProducto.Enabled = true;
            txtCantidad.Enabled = true;
            btnAgregarProducto.Enabled = true;
            btnFinalizar.Enabled = true;
            btnBuscarProducto.Enabled = true;
            gbDetalleOrdenVenta.Enabled = false;
        }

        private void btnAgregarOrdenVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDocumentoCliente.Text.Equals(""))
                {
                    MessageBox.Show("Debe llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entOrdenVenta ordVenta = new entOrdenVenta();
                    //ordVenta.numOrdenVenta = Convert.ToInt32(txtNOrdenVenta.Text.Trim());
                    ordVenta.fechaOrden = dateTimePicker1.Value;
                    ordVenta.num_documento = txtDocumentoCliente.Text.ToString();
                    ordVenta.estOrdenVenta = Convert.ToInt32(cboEstado.SelectedValue);
                    ordVenta.idTipoComprobante = Convert.ToInt32(cboTipoComprobante.SelectedValue);

                    logOrdenVenta.Instancia.InsertaOrdenVenta(ordVenta);
                    gbDetalleOrdenVenta.Enabled = true;
                    MessageBox.Show("Orden de Venta registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            gbOrdenVenta.Enabled = false;
            ListarVentas();
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIgv.Text.Equals("") || txtSubTotal.Text.Equals("") || txtTotal.Text.Equals(""))
                {
                    MessageBox.Show("Los campos estan Vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entPago Pago = new entPago();
                    Pago.NUM_ORDEN_VENTA = txtNOrdenVenta.Text.ToString();
                    Pago.SUBTOTAL = Convert.ToDecimal(txtSubTotal.Text);
                    Pago.IGV = Convert.ToDecimal(txtIgv.Text);
                    Pago.TOTAL = Convert.ToDecimal( txtTotal.Text);
                    Pago.ID_METODO_PAGO = Convert.ToInt32(cboMetodoPago.SelectedValue);
                    Pago.ID_TIPO_PAGO = Convert.ToInt32(cboTipoPago.SelectedValue);

                    logPago.Instancia.InsertarPago(Pago);                 
                    MessageBox.Show("Pago registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            LimpiarVariablesDetalle();
            gbOrdenVenta.Enabled = false;
            gbDetalleOrdenVenta.Enabled = false;

        }









        //private void btnBuscarOV_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        entOrdenVenta OrdVenta = new entOrdenVenta();
        //        OrdVenta.fechaOrden = dtpOrdenVenta.Value;
        //        dgvOrdenVenta.DataSource = logOrdenVenta.Instancia.BuscaFechaVenta(OrdVenta);
        //        if (dgvOrdenVenta.Rows.Count == 0)
        //        {
        //            MessageBox.Show("El existen ventas de esta fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            ListarVentas();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error..." + ex);
        //    }
        //}
    }
}

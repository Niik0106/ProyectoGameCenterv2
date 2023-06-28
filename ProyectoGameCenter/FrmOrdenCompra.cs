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
        public FrmOrdenCompra()
        {
            InitializeComponent();
            LlenarDatosEstadoOrdenVenta();
            ListadoOrdenesCompra();
            ListadoDetalleOrdenesCompra();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumOrdenCompra.Text.Equals("") || txtIDProveedor.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar la descripcion de un Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    entOrdenCompra ordCompra = new entOrdenCompra();
                    ordCompra.numeroOrdenCompra = Convert.ToInt32(txtNumOrdenCompra.Text.Trim());
                    ordCompra.fechaOrdenCompra = dtpFOrdenCompra.Value;
                    ordCompra.idProveedor = Convert.ToInt32(txtIDProveedor.Text.Trim());
                    ordCompra.idEstadoOrdenCompra = Convert.ToInt32(cbxEstadoCompra.SelectedValue);
                    ordCompra.fechaAtendida = dtpFAtendida.Value;
                    logOrdenCompra.Instancia.InsertarOrdenCompra(ordCompra);

                    MessageBox.Show("Orden de Compra registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error.." + ex);
            }
            ListadoOrdenesCompra();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Buscar Producto
                entProducto producto = new entProducto();
                producto = logProducto.Instancia.BuscarIDProducto(Convert.ToInt32(txtIDProducto.Text.Trim()));
                if (producto != null)
                {
                    txtDesProducto.Text = producto.desProducto.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no existe en la BD", "Buscar Provducto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }

        }

        private void btnBuscaridProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor proveedor = new entProveedor();
                proveedor = logProveedor.Instancia.BuscarIDProveedor(Convert.ToInt32(txtIDProveedor.Text.Trim()));
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
                detOrdenCompra.numeroOrdenCompra = Convert.ToInt32(txtNumOrdenCompra.Text.Trim());
                detOrdenCompra.idProducto = Convert.ToInt32(txtIDProducto.Text.Trim());
                detOrdenCompra.cantidadProducto = Convert.ToInt32(txtCantidad.Text.Trim());
                // Llamar a la función InsertarCliente
                Boolean insertado = logDetalleOrdenCompra.Instancia.InsertarDetalleOrdenCompra(detOrdenCompra);

                if (insertado)
                {
                    MessageBox.Show("El Producto se agregó exitosamente al DETALLE.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {

        }
    }
}

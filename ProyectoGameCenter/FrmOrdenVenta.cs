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

namespace ProyectoGameCenter
{
    public partial class FrmOrdenVenta : Form
    {
        public FrmOrdenVenta()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Busca Producto
            entProducto entProducto = new entProducto();
            entProducto = logProducto.Instancia.BuscaIDProducto(Convert.ToInt32(txtIDProducto.Text.Trim()));
            if (entProducto != null)
            {
                txtDesProducto.Text = entProducto.desProducto;
                txtCantidadVendida.Text = entProducto.stockProd.ToString();
                txtPrecio.Text = entProducto.precioProd.ToString();
            }
            else
            {
                MessageBox.Show("Producto no existe", "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscaridCliente_Click(object sender, EventArgs e)
        {
           /*
            try
            {
                // Crear una instancia de la clase entCliente y asignar el valor de búsqueda
                entClienteNatural filtroCliente = new entClienteNatural();
                filtroCliente.DNI = txtIDCliente.Text.Trim();
                List<entClienteNatural> listaClientes = new List<entClienteNatural>();
                // Llamar al método Buscar_Cliente para obtener los resultados de la búsqueda
                listaClientes = logClienteNatural.Instancia.BuscarDniClienteNatural(filtroCliente);
                if (listaClientes !=null && listaClientes.Count > 0)
                {
                    txtResultadoBusquedaCliente.Text = Convert.ToString(listaClientes[1]);
                }
                else
                {
                    MessageBox.Show("El Cliente NO ESTA CATALOGADO", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
           */
        }
    }
}

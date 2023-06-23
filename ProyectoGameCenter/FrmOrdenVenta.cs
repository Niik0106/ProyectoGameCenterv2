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
            entProducto = LogicaNegocio.logProducto.Instancia.BuscarProducto(Convert.ToInt32(txtIDProducto.Text.Trim()));
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
    }
}

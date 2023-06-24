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

        }

        public void LlenarDatosEstadoOrdenVenta()
        {
            cbxEstadoCompra.DataSource = logEstadoOrdenCompra.Instancia.ListaEstadoOrdenCompra();
            cbxEstadoCompra.DisplayMember = "DES_ESTADO_OC";
            cbxEstadoCompra.ValueMember = "ID_EST_ORDEN_COMPRA";
        }


    }
}

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
    public partial class FrmNotaSalida : Form
    {
        public FrmNotaSalida()
        {
            InitializeComponent();
            ListarNotaSalida();
            ListarVentas();
        }

        public void ListarNotaSalida()
        {
            dgvNotaSalida.DataSource = logNotaSalida.Instancia.ListarNotaSalida();
        }

        public void ListarVentas()
        {
            dgvOrdenVenta.DataSource = logOrdenVenta.Instancia.ListarVentas();
        }


    }
}

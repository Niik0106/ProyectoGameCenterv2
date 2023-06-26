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
    public partial class FrmCronogramaPago : Form
    {
        
        public FrmCronogramaPago()
        {
            InitializeComponent();
            LlenarDatosEstadoPago();

        }

        public void LlenarDatosEstadoPago()
        {
            cboEstadoPago.DataSource = logEstadoPago.Instancia.ListaEstadoPago();
            cboEstadoPago.DisplayMember = "DES_ESTADO_PAGO";
            cboEstadoPago.ValueMember = "ID_ESTADO_PAGO";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

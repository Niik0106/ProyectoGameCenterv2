using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGameCenter
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }
        private void MostrarBtn()
        {
            btnGuardar.Visible = true; btnCancelar.Visible = true;
        }

        private void OcultarBtn()
        {
            btnGuardar.Visible = false; btnCancelar.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarBtn();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarBtn();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OcultarBtn();
        }
    }
}

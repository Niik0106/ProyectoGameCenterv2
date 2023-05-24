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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void MostrarCampos()
        {
            imgProd.Visible = true;
            lblCat.Visible = true;
            cboCategoria.Visible = true;
            lblDescrip.Visible = true;
            txtDescripcion.Visible = true;
            lblPrecio.Visible = true;
            txtPrecio.Visible = true;
            lblStock.Visible = true;
            txtStock.Visible = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            lblMarca.Visible = true;
            cboMarca.Visible = true;
        }
        private void OcultarCampos()
        {
            imgProd.Visible = false;
            lblCat.Visible = false;
            cboCategoria.Visible = false;
            lblDescrip.Visible = false;
            txtDescripcion.Visible = false;
            lblPrecio.Visible = false;
            txtPrecio.Visible = false;
            lblStock.Visible = false;
            txtStock.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            lblMarca.Visible = false;
            cboMarca.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OcultarCampos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarCampos();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            OcultarCampos();
        }
    }
}

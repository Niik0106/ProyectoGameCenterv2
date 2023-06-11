using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGameCenter
{
    public partial class FrmClienteNatural : Form
    {
       
        public FrmClienteNatural()
        {
            InitializeComponent();
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnCerrarCN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BarraTituloCN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnAgregarCN_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnAgregarCN_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.White;
        }

        private void btnAgregarCN_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.DarkViolet;
        }

        private void btnModificarCN_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.ForeColor = Color.White;
        }

        private void btnModificarCN_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.ForeColor = Color.DarkViolet;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.DarkViolet;
        }

        private void btnNuevoCN_MouseEnter(object sender, EventArgs e)
        {
            btnNuevo.ForeColor = Color.White;
        }

        private void btnNuevoCN_MouseLeave(object sender, EventArgs e)
        {
            btnNuevo.ForeColor = Color.DarkViolet;
        }

        private void btnEditarCN_MouseEnter(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.White;
        }

        private void btnEditarCN_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.ForeColor = Color.DarkViolet;
        }

        private void btnEliminarCN_MouseEnter(object sender, EventArgs e)
        {
            btnDeshabilitarCliNat.ForeColor = Color.White;
        }

        private void btnEliminarCN_MouseLeave(object sender, EventArgs e)
        {
            btnDeshabilitarCliNat.ForeColor = Color.DarkViolet;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.DarkViolet;
        }


    }
}

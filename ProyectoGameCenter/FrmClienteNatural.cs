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
        int LX, LY;
        public FrmClienteNatural()
        {
            InitializeComponent();
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnMinimizarCN_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizarCN_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurarCN_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 700);
            this.Location = new Point(LX, LY);
            btnPCompletaCN.Visible = true;
            btnRestaurarCN.Visible = false;
        }

        private void btnCerrarCN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BarraTituloCN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelContenedorCN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCN_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnAgregarCN_MouseEnter(object sender, EventArgs e)
        {
            btnAgregarCN.ForeColor = Color.White;
        }

        private void btnAgregarCN_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarCN.ForeColor = Color.DarkViolet;
        }

        private void btnModificarCN_MouseEnter(object sender, EventArgs e)
        {
            btnModificarCN.ForeColor = Color.White;
        }

        private void btnModificarCN_MouseLeave(object sender, EventArgs e)
        {
            btnModificarCN.ForeColor = Color.DarkViolet;
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
            btnNuevoCN.ForeColor = Color.White;
        }

        private void btnNuevoCN_MouseLeave(object sender, EventArgs e)
        {
            btnNuevoCN.ForeColor = Color.DarkViolet;
        }

        private void btnEditarCN_MouseEnter(object sender, EventArgs e)
        {
            btnEditarCN.ForeColor = Color.White;
        }

        private void btnEditarCN_MouseLeave(object sender, EventArgs e)
        {
            btnEditarCN.ForeColor = Color.DarkViolet;
        }

        private void btnEliminarCN_MouseEnter(object sender, EventArgs e)
        {
            btnEliminarCN.ForeColor = Color.White;
        }

        private void btnEliminarCN_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarCN.ForeColor = Color.DarkViolet;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.DarkViolet;
        }

        private void btnPCompletaCN_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnPCompletaCN.Visible = false;
            btnRestaurarCN.Visible = true;
        }
    }
}

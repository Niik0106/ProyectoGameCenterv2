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
    public partial class FrmProveedor : Form
    {
        int LX, LY;
        public FrmProveedor()
        {
            InitializeComponent();
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnMinimizarProv_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPCompletaProv_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnPCompletaProv.Visible = false;
            btnRestaurarProv.Visible = true;
        }

        private void btnRestaurarProv_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 700);
            this.Location = new Point(LX, LY);
            btnPCompletaProv.Visible = true;
            btnRestaurarProv.Visible = false;
        }

        private void btnCerrarProv_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BarraTituloProv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevoProv_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarProv_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BarraTituloProv_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnNuevoProv_MouseEnter(object sender, EventArgs e)
        {
            btnNuevoProv.ForeColor = Color.White;
        }

        private void btnNuevoProv_MouseLeave(object sender, EventArgs e)
        {
            btnNuevoProv.ForeColor = Color.DarkViolet;
        }

        private void btnEditarProv_MouseEnter(object sender, EventArgs e)
        {
            btnEditarProv.ForeColor = Color.White;
        }

        private void btnEditarProv_MouseLeave(object sender, EventArgs e)
        {
            btnEditarProv.ForeColor = Color.DarkViolet;
        }

        private void btnEliminarProv_MouseEnter(object sender, EventArgs e)
        {
            btnEliminarProv.ForeColor = Color.White;
        }

        private void btnEliminarProv_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarProv.ForeColor = Color.DarkViolet;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.DarkViolet;
        }

        private void btnAgregarProv_MouseEnter(object sender, EventArgs e)
        {
            btnAgregarProv.ForeColor = Color.White;
        }

        private void btnAgregarProv_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarProv.ForeColor = Color.DarkViolet;
        }

        private void btnModificarProv_MouseEnter(object sender, EventArgs e)
        {
            btnModificarProv.ForeColor = Color.White;
        }

        private void btnModificarProv_MouseLeave(object sender, EventArgs e)
        {
            btnModificarProv.ForeColor = Color.DarkViolet;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.DarkViolet;
        }
    }
}

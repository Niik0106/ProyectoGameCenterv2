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
    public partial class FrmClienteJuridico : Form
    {
        int LX, LY;
        public FrmClienteJuridico()
        {
            InitializeComponent();
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnRestaurarCJ_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 700);
            this.Location = new Point(LX, LY);
            btnPCompletaCJ.Visible = true;
            btnRestaurarCJ.Visible = false;
        }

        private void btnPCompletaCJ_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnPCompletaCJ.Visible = false;
            btnRestaurarCJ.Visible = true;
        }

        private void btnMinimizarCJ_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNuevoCJ_MouseEnter(object sender, EventArgs e)
        {
            btnNuevoCJ.ForeColor = Color.White;
        }

        private void btnNuevoCJ_MouseLeave(object sender, EventArgs e)
        {
            btnNuevoCJ.ForeColor = Color.DarkViolet;
        }

        private void btnEditarCJ_MouseEnter(object sender, EventArgs e)
        {
            btnEditarCJ.ForeColor = Color.White;
        }

        private void btnEditarCJ_MouseLeave(object sender, EventArgs e)
        {
            btnEditarCJ.ForeColor = Color.DarkViolet;
        }

        private void btnEliminarCJ_MouseEnter(object sender, EventArgs e)
        {
            btnEliminarCJ.ForeColor = Color.White;
        }

        private void btnEliminarCJ_MouseLeave(object sender, EventArgs e)
        {
            btnEliminarCJ.ForeColor = Color.DarkViolet;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.DarkViolet;
        }

        private void btnAgregarCJ_MouseEnter(object sender, EventArgs e)
        {
            btnAgregarCJ.ForeColor = Color.White;
        }

        private void btnAgregarCJ_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarCJ.ForeColor = Color.DarkViolet;
        }

        private void btnModificarCJ_MouseEnter(object sender, EventArgs e)
        {
            btnModificarCJ.ForeColor = Color.White;
        }

        private void btnModificarCJ_MouseLeave(object sender, EventArgs e)
        {
            btnModificarCJ.ForeColor = Color.DarkViolet;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.White;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.ForeColor = Color.DarkViolet;
        }

        private void BarraTituloCJ_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BarraTituloCJ_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarCJ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

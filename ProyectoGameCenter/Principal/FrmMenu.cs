﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using AccesoDatos;
using Entidades;
using System.Data.SqlClient;
using FontAwesome.Sharp;
using System.Windows.Media;

namespace ProyectoGameCenter.Principal
{
    public partial class FrmMenu : Form
    {
        private int idUsuario;
        private int idRol;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Dashboard model;
        

        public FrmMenu(int idUsuario_esperado = 0, int idRolUsuario = 0)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenuLateral.Controls.Add(leftBorderBtn);
            PersonalizarDisenio();

            idUsuario = idUsuario_esperado;
            idRol = idRolUsuario;
            

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            dtpInicio.Value = DateTime.Today.AddDays(-7);
            dtpFin.Value = DateTime.Now;
            btnUlitmos7Dias.Select();

            model = new Dashboard();
            CargarDatos();
            
        }

        private void CargarDatos()
        {
            var refreshData = model.LoadData(dtpInicio.Value, dtpFin.Value);
            if (refreshData == true)
            {
                lblNumeroOrdenes.Text = model.NumOrdenes.ToString();
                lblTotalIngresos.Text = "$" + model.TotalIngresos.ToString();
                lblTotalGanancias.Text = "$" + model.TotalGanancias.ToString();
                lblNumeroClientes.Text = model.NumClientes.ToString();
                lblNumeroProveedores.Text = model.NumProveedores.ToString();
                lblNumeroProductos.Text = model.NumProductos.ToString();
                chartIngresoBruto.DataSource = model.ListaIngresoBrutos;
                chartIngresoBruto.Series[0].XValueMember = "Date";
                chartIngresoBruto.Series[0].YValueMembers = "TotalAmount";
                chartIngresoBruto.DataBind();
                chartTopProductos.DataSource = model.TopListaProductos;
                chartTopProductos.Series[0].XValueMember = "Key";
                chartTopProductos.Series[0].YValueMembers = "Value";
                chartTopProductos.DataBind();
                dgvProductosBajoStock.DataSource = model.ProductosBajoStock;
                dgvProductosBajoStock.Columns[0].HeaderText = "PRODUCTO";
                dgvProductosBajoStock.Columns[1].HeaderText = "STOCK";
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }


        //Estructuras
        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
            public static System.Drawing.Color color7 = System.Drawing.Color.FromArgb(255, 255, 255);
        }


        //Metodos
        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icono de formulario hijo
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Boton
                currentBtn.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = System.Drawing.Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //REGION DEL PANEL DE CABECERA


        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
     
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*private void btnRestaurar_Click(object sender, EventArgs e)
        {      
            this.Size = new Size(1200,700);
            this.Location = new Point(LX, LY);
            btnPCompleta.Visible = true;
            btnRestaurar.Visible = false;
        }*/
        int LX, LY;
        /*private void btnPCompleta_Click(object sender, EventArgs e)
        {
            LX = this.Location.X; 
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnPCompleta.Visible = false;
            btnRestaurar.Visible = true;
        }*/

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void panelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        //REGION DEL PANEL HORA Y FECHA

        /*private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }*/

        private void PersonalizarDisenio()
        {
            panelClienteSubMenu.Visible = false;
            panelProductoSubMenu.Visible = false;
            panelVentaSubMenu.Visible = false;
            panelComprasSubMenu.Visible = false;
            panelReportesSubMenu.Visible = false;
            panelConfiguracionSubMenu.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelClienteSubMenu.Visible == true)
                panelClienteSubMenu.Visible=false;
            if(panelProductoSubMenu.Visible ==true)
                panelProductoSubMenu.Visible=false;
            if(panelVentaSubMenu.Visible == true)
                panelVentaSubMenu.Visible=false;
            if (panelComprasSubMenu.Visible == true)
                panelComprasSubMenu.Visible=false;
            if (panelReportesSubMenu.Visible == true)
                panelReportesSubMenu.Visible=false;
            if (panelConfiguracionSubMenu.Visible == true)
                panelConfiguracionSubMenu.Visible = false;
        }

        private void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private Form FormularioActivo = null;

        private void AbrirFormularioHijo(Form FormularioHijo)
        {
            if(FormularioActivo != null)
                FormularioActivo.Close();
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(FormularioHijo);
            panelContenedor.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
            lbTitleChildForm.Text = FormularioHijo.Text;
        }

        /*private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //end
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitleChildForm.Text = childForm.Text;
        }   */

        #region REGION CLIENTE

        private void btnCliente_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelClienteSubMenu);
            ActivateButton(sender, RGBColors.color7);
        }

        private void btnClienteNatural_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmClienteNatural());
            OcultarSubMenu();
        }

        private void btnClienteJuridico_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmClienteJuridico());
            OcultarSubMenu();
        }
        #endregion

        #region REGION PRODUCTO
        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelProductoSubMenu);
            ActivateButton(sender, RGBColors.color7);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmCategoria());
            OcultarSubMenu();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMarca());
            OcultarSubMenu();
        }

        private void btnProductosSubMenu_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmProductos());
            OcultarSubMenu();
        }

        #endregion

        #region REGION VENTAS
        private void btnVentas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelVentaSubMenu);
            ActivateButton(sender, RGBColors.color7);
        }
        private void btnOrdenVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmOrdenVenta());
            OcultarSubMenu();
        }

        #endregion

        //private void btnNotaSalida_Click(object sender, EventArgs e)
        //{
        //    AbrirFormularioHijo(new FrmNotaSalida());
        //    OcultarSubMenu();
        //}

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            dgvProductosBajoStock.Columns[1].Width = 40;
            switch (idRol)
            {
                case 1: // Administrador
                    //SoundPlayer sonido = new SoundPlayer();
                    //sonido.SoundLocation = "D:/BienvenidoAdmin.wav";
                    //sonido.Play();
                    btnCliente.Enabled = true;
                    btnProductos.Enabled = true;
                    btnVentas.Enabled = true;
                    btnCompras.Enabled = true;
                    btnReportes.Enabled = true;
                    btnProveedores.Visible = true;
                    btnPagos.Visible = true;
                    btnConfiguracion.Enabled = true;
                    
   
                    break;

                case 2: // Vendedor
                    btnCliente.Enabled = true;
                    btnProductos.Visible = false;
                    btnVentas.Enabled = true;
                    btnNotaSalida.Visible=false;
                    btnProveedores.Visible = false;
                    btnReportesCompras.Visible = false;
                    btnCompras.Visible = false;
                    
                break;

                case 3: //Compras
                    btnCliente.Visible = false;
                    btnProductos.Visible = false;
                    btnVentas.Visible = false;
                    btnProveedores.Enabled = true;
                    btnReportesCompras.Visible = false;
                    btnCompras.Enabled = true;
                    btnNotaSalida.Visible = false;
                break;

                case 4: //Almacen
                    btnCliente.Visible = false;
                    btnProductos.Enabled = true;
                    btnVentas.Visible = true;
                    btnOrdenVenta.Visible = false;
                    btnOrdenCompra.Visible = false;
                    btnProveedores.Visible = false;
                    btnReportesCompras.Visible = false;
                    btnCompras.Visible = true;
                    btnNotaSalida.Enabled = true;
                break;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta Seguro que quiere Cerrar Sesion","Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                FrmLogin login = new FrmLogin();
                login.Show();
            }
           
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelComprasSubMenu);
            ActivateButton(sender, RGBColors.color7);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelReportesSubMenu);
            ActivateButton(sender, RGBColors.color7);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelConfiguracionSubMenu);
            ActivateButton(sender, RGBColors.color7);
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmProveedor());
            ActivateButton(sender, RGBColors.color7);
            OcultarSubMenu();
        }

        //private void btnNotaSalida_Click_1(object sender, EventArgs e)
        //{
        //    AbrirFormularioHijo(new FrmNotaSalida());
        //    OcultarSubMenu();
        //}

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmTipoPago());
            ActivateButton(sender, RGBColors.color7);
            OcultarSubMenu();
        }

        private void btnOrdenCompra_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmOrdenCompra());
            OcultarSubMenu();
        }

        private void panelClienteSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormularioActivo.Close();
            OcultarSubMenu();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            lbTitleChildForm.Text = "Home";
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text=DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text= DateTime.Now.ToLongDateString();
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            dtpInicio.Value = DateTime.Today;
            dtpFin.Value = DateTime.Now;
            CargarDatos();
            DesactivarFechasPersonalizadas();

        }

        private void DesactivarFechasPersonalizadas()
        {
            dtpFin.Enabled = false;
            dtpInicio.Enabled = false;
            btnOKFechaPersonalizada.Visible = false;
        }

        private void btnUlitmos7Dias_Click(object sender, EventArgs e)
        {
            dtpInicio.Value = DateTime.Today.AddDays(-7);
            dtpFin.Value = DateTime.Now;
            CargarDatos();
            DesactivarFechasPersonalizadas();
        }

        private void btn30Dias_Click(object sender, EventArgs e)
        {
            dtpInicio.Value = DateTime.Today.AddDays(-30);
            dtpFin.Value = DateTime.Now;
            CargarDatos();
            DesactivarFechasPersonalizadas();
        }

        private void btnEsteMes_Click(object sender, EventArgs e)
        {
            dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFin.Value = DateTime.Now;
            CargarDatos();
            DesactivarFechasPersonalizadas();
        }

        private void btnPersonalizadoFecha_Click(object sender, EventArgs e)
        {
            dtpFin.Enabled = true;
            dtpInicio.Enabled = true;
            btnOKFechaPersonalizada.Visible = true;
        }

        private void btnOKFechaPersonalizada_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void lblFechaInicio_Click(object sender, EventArgs e)
        {
            dtpInicio.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            lblFechaInicio.Text = dtpInicio.Text;
        }

        private void lblFechaFinal_Click(object sender, EventArgs e)
        {
            dtpFin.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            lblFechaFinal.Text = dtpFin.Text;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmUsuario());
            OcultarSubMenu();
        }

        private void btnNotaSalida_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmNotaSalida());
            OcultarSubMenu();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

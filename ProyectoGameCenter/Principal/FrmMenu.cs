using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using AccesoDatos;
using Entidades;
using System.Data.SqlClient;

namespace ProyectoGameCenter.Principal
{
    public partial class FrmMenu : Form
    {
        private int idUsuario;
        public FrmMenu(int idUsuario_esperado = 0)
        {
            InitializeComponent();
            PersonalizarDisenio();

            idUsuario = idUsuario_esperado;
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {      
            this.Size = new Size(1200,700);
            this.Location = new Point(LX, LY);
            btnPCompleta.Visible = true;
            btnRestaurar.Visible = false;
        }
        int LX, LY;
        private void btnPCompleta_Click(object sender, EventArgs e)
        {
            LX = this.Location.X; 
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnPCompleta.Visible = false;
            btnRestaurar.Visible = true;
        }

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

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void PersonalizarDisenio()
        {
            panelClienteSubMenu.Visible = false;
            panelProductoSubMenu.Visible = false;
            panelVentaSubMenu.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelClienteSubMenu.Visible == true)
                panelClienteSubMenu.Visible=false;
            if(panelProductoSubMenu.Visible ==true)
                panelProductoSubMenu.Visible=false;
            if(panelVentaSubMenu.Visible == true)
                panelVentaSubMenu.Visible=false;         
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
            FormularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(FormularioHijo);
            panelContenedor.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        #region REGION CLIENTE

        private void btnCliente_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelClienteSubMenu);
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
        }
        private void btnOrdenVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmOrdenVenta());
            OcultarSubMenu();
        }

        private void btnCronogramaPago_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmCronogramaPago());
            OcultarSubMenu();
        }

        #endregion

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmProveedor());
            OcultarSubMenu();
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMetodoPago());
            OcultarSubMenu();
        }

        private void btnNotaSalida_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new NotaSalida());
            OcultarSubMenu();
        }

        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmOrdenCompra());
            OcultarSubMenu();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            int idRol = CD_Usuario.TipoUsuario;
            switch (idRol)
            {
                case 1: // Administrador
                    btnCliente.Enabled = true;
                    btnProductos.Enabled = true;
                    btnVentas.Enabled = true;
                    btnProveedores.Enabled = true;
                    btnMetodoPago.Enabled = true;
                    btnOrdenCompra.Enabled = true;
                    btnNotaSalida.Enabled = true;
                    break;

                case 2: // Vendedor
                    btnCliente.Enabled = true;
                    btnProductos.Visible = false;
                    btnVentas.Enabled = true;
                    btnProveedores.Visible = false;
                    btnMetodoPago.Visible = false;
                    btnOrdenCompra.Visible = false;
                    btnNotaSalida.Visible = false;
                break;

                case 3: //Compras
                    btnCliente.Visible = false;
                    btnProductos.Visible = false;
                    btnVentas.Visible = false;
                    btnProveedores.Enabled = true;
                    btnMetodoPago.Visible = false;
                    btnOrdenCompra.Enabled = true;
                    btnNotaSalida.Visible = false;
                break;

                case 4: //Almacen
                    btnCliente.Visible = false;
                    btnProductos.Enabled = true;
                    btnVentas.Visible = false;
                    btnProveedores.Visible = false;
                    btnMetodoPago.Visible = false;
                    btnOrdenCompra.Visible = false;
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

        private string ObtenerPermisos(string nombreUsuario)
        {
            string rol = string.Empty;
            // Conexión a la base de datos
            using (SqlConnection conexion = new SqlConnection("cadena_de_conexion"))
            {
                conexion.Open();
                // Consulta SQL para obtener el rol del usuario
                string consulta = "SELECT Rol FROM Usuarios WHERE NombreUsuario = @NombreUsuario";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        rol = reader["Rol"].ToString();
                    }
                }
            }
            return rol;
        }
    }
}

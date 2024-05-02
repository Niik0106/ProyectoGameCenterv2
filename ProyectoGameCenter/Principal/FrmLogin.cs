using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AccesoDatos;
using Entidades;
using static AccesoDatos.CD_Usuario;

namespace ProyectoGameCenter.Principal
{
    public partial class FrmLogin : Form
    {
        private SqlConnection sqlConnection;
        int intentosFallidos = 0;
        int maximoIntentos = 5;
        int tiempoRestante = 600; 
        Timer timer;

        public FrmLogin()
        {
            InitializeComponent();
            string connectionString = "Data Source=.; Initial Catalog = PRUEBA; Integrated Security=true";
            sqlConnection = new SqlConnection(connectionString);
          
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;   
            timer.Start();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string captcha = GenerarCaptcha(6, 8);
            label4.Text = captcha;
        }

        public static string GenerarCaptcha(int longitudMinima, int longitudMaxima)
        {
            Random rand = new Random();
            int longitud = rand.Next(longitudMinima, longitudMaxima + 1); // Determinar la longitud aleatoria del captcha
            StringBuilder captcha = new StringBuilder(); // Utilizar un StringBuilder para mejorar el rendimiento en la construcción de cadenas
            int total = 0;

            do
            {
                int chr = rand.Next(48, 123); // Obtener un carácter ASCII aleatorio entre 48 y 122
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha.Append((char)chr); // Agregar el carácter al captcha
                    total++;
                    if (total == longitud)
                        break;
                }
            } while (true);

            return captcha.ToString(); // Devolver el captcha como una cadena
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
     
            tiempoRestante--;

            labelTimer.Text = this.tiempoRestante.ToString() + " Segundos";

    
            if (tiempoRestante <= 0)
            {
                timer.Stop(); 
                MessageBox.Show("Se ha agotado el tiempo. El programa se cerrará.");
                Application.Exit();
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            int idUsuario_Esperado = CD_Usuario.loguear(txtUsuario.Text, txtContrasenia.Text);

            if (idUsuario_Esperado != 0 && label4.Text == txtCaptcha.Text)
            {
                int idRolUsuario = CD_Usuario.ObtenerRol(idUsuario_Esperado);
                FrmMenu menu = new FrmMenu(idUsuario_Esperado, idRolUsuario);
                menu.Show();
                this.Hide();
                timer.Stop();
            }
            else
            {               
                intentosFallidos++;
          
                if (intentosFallidos >= maximoIntentos)
                {
                    timer.Stop(); 
                    MessageBox.Show("Se han excedido los intentos permitidos. El programa se cerrará.");
                    Application.Exit();
                }
                else
                {
                    if (label4.Text != txtCaptcha.Text)
                    {
                        MessageBox.Show("CAPTCHA incorrecto, intente nuevamente");
                        string captcha = GenerarCaptcha(6, 8);
                        label4.Text = captcha;
                    }
                    
                    int intentosRestantes = maximoIntentos - intentosFallidos;

                    MessageBox.Show("Usuario y/o contraseña incorrectos. Te quedan " + intentosRestantes + " intentos.");
                    txtUsuario.Clear();
                    txtContrasenia.Clear();
                    txtCaptcha.Clear();
                }
            }

        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filePath = @"C:\Users\rocke\OneDrive\Documentos\DECLARACIÓN DE PRIVACIDAD.pdf";

            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }

        private void linkRestablecer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRestablecerContrasenia restContra = new FrmRestablecerContrasenia();
            restContra.Show();
        }

        private void picAbierto1_Click(object sender, EventArgs e)
        {
            txtContrasenia.PasswordChar = '\0';
            picAbierto1.Visible = false;
            picCerrado1.Visible = true;
        }

        private void picCerrado1_Click(object sender, EventArgs e)
        {
            txtContrasenia.PasswordChar = '*';
            picAbierto1.Visible = true;
            picCerrado1.Visible = false;
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}

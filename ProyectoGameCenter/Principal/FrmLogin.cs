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

namespace ProyectoGameCenter.Principal
{
    public partial class FrmLogin : Form
    {
        private SqlConnection sqlConnection;
        int intentosFallidos = 0;
        int maximoIntentos = 5;
        int tiempoRestante = 60; 
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
            Random rand = new Random();
            int num = rand.Next(6, 8);
            string captcha = "";
            int total = 0;
            do
            {
                int chr = rand.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha += (char)chr;
                    total++;
                    if (total == num)
                        break;
                    {

                    }
                }
            } while (true);
            label4.Text = captcha;
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
            string filePath = @"D:\CICLO 8\CALIDAD Y PRUEBAS\DECLARACIÓN DE PRIVACIDAD.pdf";

            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }


    }
}

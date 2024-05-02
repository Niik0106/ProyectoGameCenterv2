using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using static AccesoDatos.CD_Usuario;

namespace ProyectoGameCenter.Principal
{
    public partial class FrmRestablecerContrasenia : Form
    {
        private string correoUsuario; 
        private string codigoAleatorio;

        public FrmRestablecerContrasenia()
        {
            InitializeComponent();
        }
        public static string GenerarCodigo(int longitud)
        {
            const string CaracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            char[] codigo = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                codigo[i] = CaracteresPermitidos[random.Next(CaracteresPermitidos.Length)];
            }
            return new string(codigo);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            correoUsuario = txtCorreo.Text.Trim();

            if (!string.IsNullOrEmpty(correoUsuario))
            {
                string correoElectronico = CD_Usuario.ObtenerCorreoPorUsuario(correoUsuario);

                if (!string.IsNullOrEmpty(correoElectronico))
                {
                    codigoAleatorio = GenerarCodigo(8); // Generar código aleatorio
                    EnviarCorreoElectronico(correoElectronico, codigoAleatorio); // Enviar código por correo electrónico

                    MessageBox.Show($"Se ha enviado un código al correo: {correoElectronico}");
                    correoUsuario = correoElectronico; // Almacenar el correo del usuario
                    label1.Text = "CODIGO";
                    txtCorreo.Text = string.Empty;
                    btnEnviar.Visible = false;
                    btnCodigo.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún correo asociado al usuario o correo ingresado");
                    txtCorreo.Text = string.Empty;
                    txtCorreo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre de usuario o correo electrónico antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void EnviarCorreoElectronico(string destinatario, string codigo)
        {
            string remitente = "rocketmc2015@gmail.com";
            string contraseñaApp = "tcqz lwsr audf levy";

            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(remitente, contraseñaApp) // Utiliza la contraseña de aplicación aquí
            };

            // Crear el mensaje de correo electrónico
            MailMessage mensaje = new MailMessage(remitente, destinatario)
            {
                Subject = "GAME CENTER S.A.C - CÓDIGO DE VERIFICACIÓN",
                Body = $"Su código de verificación es: {codigo}"
            };

            try
            {
                clienteSmtp.Send(mensaje);
                MessageBox.Show("Correo electrónico enviado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo electrónico: " + ex.Message);
            }
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            string codigo = txtCorreo.Text.Trim();

            if (!string.IsNullOrEmpty(codigo))
            {
                if (codigo == codigoAleatorio)
                {
                    MessageBox.Show("Los códigos coinciden correctamente");
                    label1.Visible = false; btnCodigo.Visible = false;
                    txtCorreo.Text = string.Empty; txtCorreo.Visible = false;
                    lblDisclaimer.Visible = true; label2.Visible = true;
                    label3.Visible = true; txtContrasenia.Visible = true;
                    txtConfirmar.Visible = true; btnRestablecer.Visible = true;
                    picAbierto1.Visible = true; picAbierto2.Visible = true;
                    progressBar1.Visible = true; lblNivel.Visible = true;
                    lblDisclaimer.Text = "Requisitos de contraseña:\n" +
                                    "- Mínimo 8 caracteres de longitud\n" +
                                    "- Al menos una letra MAYÚSCULA\n" +
                                    "- Al menos un número\n" +
                                    "- Al menos un carácter especial";
                }
                else
                {
                    MessageBox.Show("Los códigos no coinciden, intente nuevamente");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese el código que se le ha enviado a su correo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string nuevaContraseña = txtContrasenia.Text;
            string confirmarContraseña = txtConfirmar.Text;

            // Validar que las contraseñas coincidan y cumplan con los requisitos de seguridad
            if (nuevaContraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarContraseña(nuevaContraseña))
            {
                MessageBox.Show("La contraseña no cumple con los requisitos mínimos de seguridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar la contraseña del usuario en la base de datos
            if (CD_Usuario.ActualizarContraseña(correoUsuario, nuevaContraseña))
            {
                MessageBox.Show("La contraseña se actualizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FrmLogin login = new FrmLogin();
                login.Show();
            }
            else
            {
                MessageBox.Show("Error al actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarContraseña(string contraseña)
        {
            // Requisitos de contraseña: mínimo 8 caracteres, al menos una mayúscula, al menos un número, al menos un carácter especial
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$");
            return regex.IsMatch(contraseña);
        }

        private void picCerrado2_Click(object sender, EventArgs e)
        {
            txtConfirmar.PasswordChar = '*';
            picAbierto2.Visible = true;
            picCerrado2.Visible = false;
        }

        private void picCerrado1_Click(object sender, EventArgs e)
        {
            txtContrasenia.PasswordChar = '*';
            picAbierto1.Visible = true;
            picCerrado1.Visible = false;
        }

        private void picAbierto1_Click(object sender, EventArgs e)
        {
            txtContrasenia.PasswordChar = '\0';
            picAbierto1.Visible = false;
            picCerrado1.Visible = true;
        }

        private void picAbierto2_Click(object sender, EventArgs e)
        {
            txtConfirmar.PasswordChar = '\0';
            picAbierto2.Visible = false;
            picCerrado2.Visible = true;
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            NivelSeguridad nivel = CD_Usuario.EvaluarContraseña(txtContrasenia.Text);
            switch (nivel)
            {
                case NivelSeguridad.Debil:
                    progressBar1.Value = 25;
                    lblNivel.Text = "Débil";
                    break;
                case NivelSeguridad.Moderado:
                    progressBar1.Value = 50;
                    lblNivel.Text = "Moderado";
                    break;
                case NivelSeguridad.Fuerte:
                    progressBar1.Value = 75;
                    lblNivel.Text = "Fuerte";
                    break;
                case NivelSeguridad.MuyFuerte:
                    progressBar1.Value = 100;
                    lblNivel.Text = "Muy Fuerte";
                    break;
            }
        }
    }
}


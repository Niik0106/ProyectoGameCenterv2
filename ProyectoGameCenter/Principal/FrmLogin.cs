using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        public FrmLogin()
        {
            InitializeComponent();
            string connectionString = "Data Source=.; Initial Catalog = MOANSO; Integrated Security=true";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            /*if (txtUsuario.Text == "admin" && txtContrasenia.Text == "123")
            {
                FrmMenu menu = new FrmMenu();
                menu.Show();
                this.Hide();
            }
            else if (txtUsuario.Text == "" || txtContrasenia.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                MessageBox.Show("USUARIO Y CONTRASEÑA INCORRECTOS");
            }*/

            
            int idUsuario_Esperado = CD_Usuario.loguear(txtUsuario.Text, txtContrasenia.Text);

            if(idUsuario_Esperado != 0)
            {
                FrmMenu menu = new FrmMenu(idUsuario_Esperado);
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }

        }
    }
}

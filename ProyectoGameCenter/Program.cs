using ProyectoGameCenter.Principal;
using System;
using System.Windows.Forms;

namespace ProyectoGameCenter
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FrmMenu());
=======
            Application.Run(new FrmProveedor());
            
>>>>>>> Malleck
        }
    }
}

using System;
using System.Windows.Forms;

namespace IS2026_Service_82CD_
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

            // Dejamos tu formulario de Login para que arranque la app
            Application.Run(new frmLogin_82CD());
        }
    }
}
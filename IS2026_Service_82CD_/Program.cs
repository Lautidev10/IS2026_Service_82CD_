using System;
using System.Windows.Forms;

namespace IS2026_Service_82CD_
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin_82CD());
        }
    }
}
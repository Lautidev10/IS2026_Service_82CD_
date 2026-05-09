using System;
using System.Windows.Forms;

namespace IS2026_Service_82CD_
{
    public partial class frmMenuPrincipal_82CD : Form
    {
        public frmMenuPrincipal_82CD()
        {
            InitializeComponent();
        }

        private void lblAdministradores_82CD_Click(object sender, EventArgs e)
        {
            frmAdmin_82CD frmAdmin_82CD = new frmAdmin_82CD();
            frmAdmin_82CD.Show();

        }
    }
}

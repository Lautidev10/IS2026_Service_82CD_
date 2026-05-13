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

        public void EnDesarrollo()
        {
           MessageBox.Show("Estamos trabajando en eso ;)");
        }

        private void lblUsuarios_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo();
        }

        private void lblMaestros_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo();
        }

        private void lblNegocio1_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo();
        }

        private void lblNegocio2_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo();
        }

        private void lblReportes_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo();
        }

        private void lblAyuda_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo();
        }

    }
}

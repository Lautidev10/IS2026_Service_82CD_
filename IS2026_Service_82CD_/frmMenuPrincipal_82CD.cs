using BE;
using Servicio;
using System;
using System.Windows.Forms;
using System.Xml.Schema;

namespace IS2026_Service_82CD_
{
    public partial class frmMenuPrincipal_82CD : Form
    {
        private string rolUsuario_82CD;

        public frmMenuPrincipal_82CD(string rol_82CD)
        {
            InitializeComponent();
            this.rolUsuario_82CD = rol_82CD;
        }

        private void frmMenuPrincipal_82CD_Load(object sender, EventArgs e)
        {
            try
            {
                UsuarioBE_82CD usuarioactual_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
                ModoMenuPrincipal_82CD();
            }
            catch
            {
                MessageBox.Show("Error al cargar el menu");
            }
        }


        private void ModoMenuPrincipal_82CD()
        {
            switch (rolUsuario_82CD)
            {
                case "Administrador":
                    lblUsuarios_82CD.Visible = true;
                    lblAdministradores_82CD.Visible = true;
                    lblMaestros_82CD.Visible = true;
                    lblNegocio1_82CD.Visible = true;
                    lblNegocio2_82CD.Visible = true;
                    lblReportes_82CD.Visible = true;
                    lblAyuda_82CD.Visible = true;
                    break;

                case "Cliente":
                    lblUsuarios_82CD.Visible = true;
                    lblAdministradores_82CD.Visible = false;
                    lblMaestros_82CD.Visible = false;
                    lblNegocio1_82CD.Visible = true;
                    lblNegocio2_82CD.Visible = true;
                    lblReportes_82CD.Visible = true;
                    lblAyuda_82CD.Visible = true;
                    break;
            }
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

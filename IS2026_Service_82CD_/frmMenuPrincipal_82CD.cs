
using Servicio;
using System;
using System.Windows.Forms;
using System.Xml.Schema;

namespace IS2026_Service_82CD_
{
    public partial class frmMenuPrincipal_82CD : Form
    {
        
        private ServicioRol_82CD rolUsuario_82CD;

        public frmMenuPrincipal_82CD(ServicioRol_82CD rolIngresado_82CD)
        {
            InitializeComponent();
            this.rolUsuario_82CD = rolIngresado_82CD;
        }

        private void frmMenuPrincipal_82CD_Load(object sender, EventArgs e)
        {
            try
            {
                //ServicioUsuario_82CD usuarioactual_82CD = SessionManager_82CD.ObtenerUsuario_82CD(); Para que el menu salude al usuario que inicio sesion
                ModoMenuPrincipal_82CD();
            }
            catch
            {
                MessageBox.Show("Error al cargar el menu");
            }
        }


        private void ModoMenuPrincipal_82CD()
        {
            switch (rolUsuario_82CD.NombreRol_82CD)
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
            ContextMenuStrip contextms_82CD = new ContextMenuStrip();
            
            ToolStripMenuItem itemGestion_82CD = new ToolStripMenuItem("Gestión de Usuarios");
            itemGestion_82CD.Click += itemGestion_82CD_Click;
            
            ToolStripMenuItem itemBitacora_82CD = new ToolStripMenuItem("Bitácora");
            itemBitacora_82CD.Click += itemBitacora_82CD_Click;

            contextms_82CD.Items.Add(itemGestion_82CD);
            contextms_82CD.Items.Add(itemBitacora_82CD);

            contextms_82CD.Show(lblAdministradores_82CD, new System.Drawing.Point(0, lblAdministradores_82CD.Height));
        }

        private void itemGestion_82CD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin_82CD frmAdmin_82CD = new frmAdmin_82CD();
            frmAdmin_82CD.Show();
        }

        private void itemBitacora_82CD_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBitacora_82CD frmbitacora_82CD = new FrmBitacora_82CD();
            frmbitacora_82CD.Show();
        }


        private void EnDesarrollo_82CD()
        {
           MessageBox.Show("Estamos trabajando en eso ;)");
        }

        private void lblUsuarios_82CD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVistaUsuario_82CD frmVistaUsuario_82CD = new frmVistaUsuario_82CD();
            frmVistaUsuario_82CD.Show();
        }

        private void lblMaestros_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo_82CD();
        }

        private void lblNegocio1_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo_82CD();
        }

        private void lblNegocio2_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo_82CD();
        }

        private void lblReportes_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo_82CD();
        }

        private void lblAyuda_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo_82CD();
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

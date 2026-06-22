
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
            lblUsuarios_82CD.Visible = rolUsuario_82CD.TienePermiso_82CD("Cambiar Contraseña");

            lblAdministradores_82CD.Visible =
                rolUsuario_82CD.TienePermiso_82CD("Crear Usuario") &&
                rolUsuario_82CD.TienePermiso_82CD("Modificar Usuario") &&
                rolUsuario_82CD.TienePermiso_82CD("Activar/Desactivar Usuario") &&
                rolUsuario_82CD.TienePermiso_82CD("Desbloquear Usuario") &&
                rolUsuario_82CD.TienePermiso_82CD("Ver Bitácora") &&
                rolUsuario_82CD.TienePermiso_82CD("Crear Rol") &&
                rolUsuario_82CD.TienePermiso_82CD("Eliminar Rol") &&
                rolUsuario_82CD.TienePermiso_82CD("Crear Familia") &&
                rolUsuario_82CD.TienePermiso_82CD("Eliminar Familia");

            lblMaestros_82CD.Visible = true;
            lblNegocio1_82CD.Visible = true;
            lblNegocio2_82CD.Visible = true;
            lblReportes_82CD.Visible = true;
            lblAyuda_82CD.Visible = true;
        }

        private void lblAdministradores_82CD_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextms_82CD = new ContextMenuStrip();
            
            bool puedeGestionarUsuarios_82CD =
                rolUsuario_82CD.TienePermiso_82CD("Crear Usuario") &&
                rolUsuario_82CD.TienePermiso_82CD("Modificar Usuario") &&
                rolUsuario_82CD.TienePermiso_82CD("Activar/Desactivar Usuario") &&
                rolUsuario_82CD.TienePermiso_82CD("Desbloquear Usuario");

            if (puedeGestionarUsuarios_82CD)
            { 
                ToolStripMenuItem itemGestion_82CD = new ToolStripMenuItem("Gestión de Usuarios");
                itemGestion_82CD.Click += itemGestionUsuarios_82CD_Click;
                contextms_82CD.Items.Add(itemGestion_82CD);
            }

            if (rolUsuario_82CD.TienePermiso_82CD("Ver Bitácora"))
            {
                ToolStripMenuItem itemBitacora_82CD = new ToolStripMenuItem("Ver Bitácora");
                itemBitacora_82CD.Click += itemBitacora_82CD_Click;
                contextms_82CD.Items.Add(itemBitacora_82CD);
            }

            bool puedeGestionarPerfiles_82CD =
                rolUsuario_82CD.TienePermiso_82CD("Crear Rol") &&
                rolUsuario_82CD.TienePermiso_82CD("Eliminar Rol") &&
                rolUsuario_82CD.TienePermiso_82CD("Crear Familia") &&
                rolUsuario_82CD.TienePermiso_82CD("Eliminar Familia");

            if (puedeGestionarPerfiles_82CD)
            {
                ToolStripMenuItem itemGestion_82CD = new ToolStripMenuItem("Gestionar Perfiles");
                itemGestion_82CD.Click += itemGestionPerfiles_82CD_Click;
                contextms_82CD.Items.Add(itemGestion_82CD);
            }

            contextms_82CD.Show(lblAdministradores_82CD, new System.Drawing.Point(0, lblAdministradores_82CD.Height));
        }

        private void itemGestionUsuarios_82CD_Click(object sender, EventArgs e)
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

        private void itemGestionPerfiles_82CD_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPerfiles_82CD frmPerfiles_82CD = new FrmPerfiles_82CD();
            frmPerfiles_82CD.Show();
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

    }
}

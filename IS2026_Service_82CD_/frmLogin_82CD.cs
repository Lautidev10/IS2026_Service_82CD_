using BE;
using DAL;
using Servicio;
using System;
using System.Windows.Forms;

namespace IS2026_Service_82CD_
{
    public partial class frmLogin_82CD : Form
    {
        public frmLogin_82CD()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_82CD_Click(object sender, EventArgs e)
        {
            try
            {
                string login_82CD = txtUsuario_82CD.Text;

                string password_82CD = txtContraseña_82CD.Text;

                string hash_82CD = ServicioEncriptacion_82CD.Encriptar_82CD(password_82CD);

                MapperUsuario_82CD mapperusuario_82CD = new MapperUsuario_82CD();

                UsuarioBE_82CD usuario_82CD = mapperusuario_82CD.ValidarLogin_82CD(login_82CD, hash_82CD);

                if (usuario_82CD != null)
                {
                    MessageBox.Show("Bienvenido");

                    frmMenuPrincipal_82CD frmMenu = new frmMenuPrincipal_82CD();
                    frmMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

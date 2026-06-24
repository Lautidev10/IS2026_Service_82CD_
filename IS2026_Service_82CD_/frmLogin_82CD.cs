using BLL;
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

        BLLUsuario_82CD bllUsuario_82CD = new BLLUsuario_82CD();
        BLLRol_82CD bllRol_82CD = new BLLRol_82CD();

        private bool ValidarCampos_82CD()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario_82CD.Text) || string.IsNullOrWhiteSpace(txtContraseña_82CD.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LimpiarControles()
        {
            txtUsuario_82CD.Text = "";
            txtContraseña_82CD.Text = "";
        }


        private void btnIniciarSesion_82CD_Click(object sender, EventArgs e)
        {
            bool validar_82CD = ValidarCampos_82CD();

            if (validar_82CD)
            {
                try
                {
                    string login_82CD = txtUsuario_82CD.Text;
                    string password_82CD = txtContraseña_82CD.Text;

                    
                    ServicioUsuario_82CD usuario_82CD = bllUsuario_82CD.ValidarCredenciales_82CD(login_82CD, password_82CD);
                    ServicioRol_82CD rol_82CD = bllRol_82CD.CargarRol_82CD(usuario_82CD.IdRol_82CD);
                    MostrarMenuPrincipal_82CD(rol_82CD);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar Usuario y Contraseña");
            }
            LimpiarControles();
        }
        
        private void MostrarMenuPrincipal_82CD(ServicioRol_82CD rol_82CD)
        {
            frmMenuPrincipal_82CD frmMenuPrincipal_82CD = new frmMenuPrincipal_82CD(rol_82CD);
            frmMenuPrincipal_82CD.Show();
            this.Hide();
        }

        private void frmLogin_82CD_Load(object sender, EventArgs e)
        {
            try
            {
                bllRol_82CD.VerificarRolesBase_82CD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
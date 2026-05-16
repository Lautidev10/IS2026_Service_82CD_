using BE;
using BLL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IS2026_Service_82CD_
{
    public partial class frmVistaUsuario_82CD : Form
    {
        public frmVistaUsuario_82CD()
        {
            InitializeComponent();
        }

        private BLLBitacora_82CD bllbitacora_82CD = new BLLBitacora_82CD();
        private BLLUsuario_82CD bllusuario_82CD = new BLLUsuario_82CD();

        private void btnCerrarSesion_82CD_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult confirmacion_82CD = MessageBox.Show("Desea cerrar la sesion?",
                    "Confirmar cierre de sesion?", MessageBoxButtons.YesNo);

                if(confirmacion_82CD == DialogResult.No)
                {
                    MessageBox.Show("Se cancelo el cierre de sesion");
                }
                else
                {
                    UsuarioBE_82CD sesion_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
                    //Registrar con el usuario el evento cierre en bitacora

                    SessionManager_82CD.CerrarSesion_82CD();

                    List<Form> formActivas_82CD = new List<Form>();
                    foreach(Form form_82CD in Application.OpenForms)
                    {
                        if(!(form_82CD is frmLogin_82CD))
                        {
                            formActivas_82CD.Add(form_82CD);
                        }
                    }

                    foreach(Form form_82CD in formActivas_82CD)
                    {
                        form_82CD.Close();
                    }

                    foreach(Form form_82CD in Application.OpenForms)
                    {
                        if(form_82CD is frmLogin_82CD)
                        {
                            form_82CD.Show();
                            break;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al cerrar sesion");
            }
        }

        private void EnDesarrollo_82CD()
        {
            MessageBox.Show("Estamos trabajando en eso ;)");
        }

        private void btnDesbloquear_82CD_Click(object sender, System.EventArgs e)
        {
            EnDesarrollo_82CD();
        }

        private void btnCambiarIdioma_82CD_Click(object sender, System.EventArgs e)
        {
            EnDesarrollo_82CD();
        }

        private void btnCambiarContraseña_82CD_Click(object sender, System.EventArgs e)
        {
            try
            {
                bllusuario_82CD.ActualizarContraseña_82CD(
                    txtContraseñaActual_82CD.Text,
                    txtNuevaContraseña_82CD.Text,
                    txtConfirmacion_82CD.Text
                    );

                MessageBox.Show("Contraseña actualizada correctamente");

                txtContraseñaActual_82CD.Clear();
                txtNuevaContraseña_82CD.Clear();
                txtConfirmacion_82CD.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCancelar_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo_82CD();
        }

        private void btnConfirmar_82CD_Click(object sender, EventArgs e)
        {
            EnDesarrollo_82CD();
        }

        private void lblSalir_82CD_Click(object sender, EventArgs e)
        {
            foreach (Form form_82CD in Application.OpenForms)
            {
                if (form_82CD is frmMenuPrincipal_82CD)
                {
                    form_82CD.Show();
                    break;
                }
            }
            this.Hide();
        }
    }
}

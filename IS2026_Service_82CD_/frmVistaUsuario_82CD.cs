using BLL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Windows.Forms;


namespace IS2026_Service_82CD_
{
    public partial class frmVistaUsuario_82CD : Form
    {
        public frmVistaUsuario_82CD()
        {
            InitializeComponent();
        }

        private BLLEvento_82CD BLLEvento_82CD = new BLLEvento_82CD();
        private BLLUsuario_82CD bllusuario_82CD = new BLLUsuario_82CD();
        private ModoFrmVistaUsuario_82CD modoVistaUsuario_82CD = ModoFrmVistaUsuario_82CD.Vista_82CD;

        private enum ModoFrmVistaUsuario_82CD
        {
            Vista_82CD,
            CambiarContraseña_82CD,
        }


        private void btnCerrarSesion_82CD_Click(object sender, System.EventArgs e)
        {
            try
            {
                DialogResult confirmacion_82CD = MessageBox.Show("Desea cerrar la sesion?",
                    "Confirmar cierre de sesion", MessageBoxButtons.YesNo);

                if(confirmacion_82CD == DialogResult.No)
                {
                    MessageBox.Show("Se cancelo el cierre de sesion");
                }
                else
                {
                    bllusuario_82CD.CerrarSesion_82CD();
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
            CambiarModo_82CD(ModoFrmVistaUsuario_82CD.CambiarContraseña_82CD);
        }

        private void LimpiarControles()
        {
            txtContraseñaActual_82CD.Text = "";
            txtNuevaContraseña_82CD.Text = "";
            txtConfirmacion_82CD.Text = "";
        }


        private void btnCancelar_82CD_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            CambiarModo_82CD(ModoFrmVistaUsuario_82CD.Vista_82CD);
        }

        private void btnConfirmar_82CD_Click(object sender, EventArgs e)
        {
            try
            {
                if (modoVistaUsuario_82CD == ModoFrmVistaUsuario_82CD.CambiarContraseña_82CD)
                {
                    string contraseñaActual_82CD = txtContraseñaActual_82CD.Text;
                    string nuevaContraseña_82CD = txtNuevaContraseña_82CD.Text;
                    string confirmacion_82CD = txtConfirmacion_82CD.Text;

                    if (String.IsNullOrEmpty(contraseñaActual_82CD))
                    {
                        MessageBox.Show("Debe ingresar su contraseña actual");
                        return;
                    }
                    if (String.IsNullOrEmpty(nuevaContraseña_82CD) || String.IsNullOrEmpty(confirmacion_82CD))
                    {
                        MessageBox.Show("Debe ingresar una nueva contraseña y su confirmacion");
                        return;
                    }

                    bllusuario_82CD.ActualizarContraseña_82CD(contraseñaActual_82CD, nuevaContraseña_82CD, confirmacion_82CD);
                    MessageBox.Show("Contraseña actualizada correctamente");
                    bllusuario_82CD.CerrarSesion_82CD();
                    List<Form> formularios_82CD = new List<Form>();

                    foreach (Form form_82CD in Application.OpenForms)
                    {
                        if(!(form_82CD is frmLogin_82CD))
                        {
                            formularios_82CD.Add(form_82CD);
                        }
                    }

                    foreach(Form form_82CD in formularios_82CD)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void CambiarModo_82CD(ModoFrmVistaUsuario_82CD modo_82CD)
        {
            modoVistaUsuario_82CD = modo_82CD;

            switch (modo_82CD)
            {
                case ModoFrmVistaUsuario_82CD.Vista_82CD:

                    lblUsuarioActual_82CD.Visible = false;
                    txtUsuarioActual_82CD.Visible = false;

                    lblDNI_82CD.Visible = false;
                    txtDNI_82CD.Visible = false;
                    lblNombre_82CD.Visible = false;
                    txtNombre_82CD.Visible = false;
                    lblApellido_82CD.Visible = false;
                    txtApellido_82CD.Visible = false;
                    lblLogin_82CD.Visible = false;
                    txtLogin_82CD.Visible = false;
                    lbLRol_82CD.Visible = false;
                    txtRol_82CD.Visible = false;
                    lblEmail.Visible = false;
                    txtEmail_82CD.Visible = false;
                    panel_82CD.Visible = false;

                    lblContraseñaActual_82CD.Visible = false;
                    txtContraseñaActual_82CD.Visible = false;
                    lblNuevaContraseña_82CD.Visible = false;
                    txtNuevaContraseña_82CD.Visible = false;
                    lblConfirmacion_82CD.Visible = false;
                    txtConfirmacion_82CD.Visible = false;
                    panel2_82CD.Visible = false;

                    btnConfirmar_82CD.Visible = false;
                    btnCancelar_82CD.Visible=false;

                    btnCambiarContraseña_82CD.Visible = true;
                    btnCambiarIdioma_82CD.Visible = true;
                    btnCerrarSesion_82CD.Visible = true;
                    btnRelogin_82CD.Visible = true;
                    panelBotones_82CD.Visible = true;

                    break;


                case ModoFrmVistaUsuario_82CD.CambiarContraseña_82CD:

                    lblUsuarioActual_82CD.Visible = true;
                    txtUsuarioActual_82CD.Visible = true;

                    lblContraseñaActual_82CD.Visible = true;
                    txtContraseñaActual_82CD.Visible = true;
                    lblNuevaContraseña_82CD.Visible = true;
                    txtNuevaContraseña_82CD.Visible = true;
                    lblConfirmacion_82CD.Visible = true;
                    txtConfirmacion_82CD.Visible = true;
                    panel2_82CD.Visible = true;

                    btnConfirmar_82CD.Visible = true;
                    btnCancelar_82CD.Visible = true;

                    btnCambiarContraseña_82CD.Visible = false;
                    btnCambiarIdioma_82CD.Visible = false;
                    btnCerrarSesion_82CD.Visible = false;
                    btnRelogin_82CD.Visible = false;
                    panelBotones_82CD.Visible = false;
                    
                    break;
            }
        }

        private void frmVistaUsuario_82CD_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            //Metodo para roles con cmbbox como FrmAdmin
            ServicioUsuario_82CD usuario_82CD = SessionManager_82CD.ObtenerUsuario_82CD();
            txtUsuarioActual_82CD.Text = usuario_82CD.LogIn_82CD;

            CambiarModo_82CD(ModoFrmVistaUsuario_82CD.Vista_82CD);
        }


    }
}

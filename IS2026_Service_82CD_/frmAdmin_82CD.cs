using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IS2026_Service_82CD_
{
    public partial class frmAdmin_82CD : Form
    {

        private BLLUsuario_82CD bllUsuario_82CD = new BLLUsuario_82CD();
        private BLLBitacora_82CD bllbitacora_82CD = new BLLBitacora_82CD();
        private ModoFrmAdmin_82CD modoActual_82CD = ModoFrmAdmin_82CD.Consulta_82CD;

        public frmAdmin_82CD()
        {
            InitializeComponent();
        }

        public enum ModoFrmAdmin_82CD
        {
            Consulta_82CD,
            Añadir_82CD
        }

        private void frmAdmin_82CD_Load(object sender, EventArgs e)
        {
            LimpiarControles_82CD();
            CargarUsuarios_82CD();
            CambiarModo_82CD(ModoFrmAdmin_82CD.Consulta_82CD);
        }



        private void CargarUsuarios_82CD()
        {
            try
            {
                List<UsuarioBE_82CD> usuarios_82CD = bllUsuario_82CD.ListarUsuario_82CD(false);

                List<UsuarioBE_82CD> listaMostrar_82CD = new List<UsuarioBE_82CD>();

                foreach (UsuarioBE_82CD u in usuarios_82CD)
                {
                    {
                        UsuarioBE_82CD usuario_82CD = new UsuarioBE_82CD();

                        usuario_82CD.DNI_82CD = u.DNI_82CD;
                        usuario_82CD.Apellidos_82CD = u.Apellidos_82CD;
                        usuario_82CD.Nombre_82CD = u.Nombre_82CD;
                        usuario_82CD.Email_82CD = u.Email_82CD;
                        usuario_82CD.LogIn_82CD = u.LogIn_82CD;
                        usuario_82CD.IdRol_82CD = u.IdRol_82CD;
                        usuario_82CD.Password_82CD = u.Password_82CD;
                        usuario_82CD.Bloqueado_82CD = u.Bloqueado_82CD;
                        usuario_82CD.Activo_82CD = u.Activo_82CD;

                        listaMostrar_82CD.Add(usuario_82CD);
                    }
                }

                DGUsuarios_82CD.DataSource = listaMostrar_82CD;

                lclCantUsuarios_82CD.Text = DGUsuarios_82CD.Rows.Count.ToString();
            }
            catch
            {
                CargarMensajes_82CD("Error al cargar usuarios");
            }
        }


        private void CambiarModo_82CD(ModoFrmAdmin_82CD modo)
        {
            modoActual_82CD = modo;

            switch (modo)
            {
                case ModoFrmAdmin_82CD.Consulta_82CD:

                    lblDNI_82CD.Visible = false;
                    txtDNI_82CD.Visible = false;
                    lblApellidos_82CD.Visible = false;
                    txtApellidos_82CD.Visible = false;
                    lblNombre_82CD.Visible = false;
                    txtNombre_82CD.Visible = false;
                    lblEmail_82CD.Visible = false;
                    txtEmail_82CD.Visible = false;
                    lblRol_82CD.Visible = false;
                    cmbRol_82CD.Visible = false;
                    lblLogin_82CD.Visible = false;
                    txtLogin_82CD.Visible = false;

                    lblBloqueado_82CD.Visible = false;
                    txtBloqueado_82CD.Visible = false;
                    lblActivo_82CD.Visible = false;
                    txtActivo_82CD.Visible = false;

                    btnCrear_82CD.Visible = true;
                    btnDesbloquear_82CD.Visible = true;
                    btnModificar_82CD.Visible = true;
                    btnActDesact_82CD.Visible = true;

                    btnAplicar_82CD.Visible = false;
                    btnCancelar_82CD.Visible = false;

                    CargarMensajes_82CD("Modo Consulta");

                    break;


                case ModoFrmAdmin_82CD.Añadir_82CD:

                    lblDNI_82CD.Visible = true;
                    txtDNI_82CD.Visible = true;
                    lblApellidos_82CD.Visible = true;
                    txtApellidos_82CD.Visible = true;
                    lblNombre_82CD.Visible = true;
                    txtNombre_82CD.Visible = true;
                    lblEmail_82CD.Visible = true;
                    txtEmail_82CD.Visible = true;
                    lblRol_82CD.Visible = true;
                    cmbRol_82CD.Visible = true;
                    lblLogin_82CD.Visible = false;
                    txtLogin_82CD.Visible = false;
                    lblBloqueado_82CD.Visible = false;
                    txtBloqueado_82CD.Visible = false;
                    lblActivo_82CD.Visible = false;
                    txtActivo_82CD.Visible = false;

                    btnCrear_82CD.Visible = false;
                    btnDesbloquear_82CD.Visible = false;
                    btnModificar_82CD.Visible = false;
                    btnActDesact_82CD.Visible = false;

                    btnAplicar_82CD.Visible = true;
                    btnCancelar_82CD.Visible = true;

                    CargarMensajes_82CD("Modo Añadir");

                    break;
            }

            btnSalir_82CD.Visible = true;
        }

        private void CargarMensajes_82CD(string texto)
        {
            rtbMensaje_82CD.Clear();
            rtbMensaje_82CD.AppendText(texto);
        }

        private void LimpiarControles_82CD()
        {
            txtDNI_82CD.Text = "";
            txtApellidos_82CD.Text = "";
            txtNombre_82CD.Text = "";
            txtEmail_82CD.Text = "";
            cmbRol_82CD.Text = "";
            txtLogin_82CD.Text = "";
            txtBloqueado_82CD.Text = "";
            txtActivo_82CD.Text = "";
        }

        private void btnCrear_82CD_Click(object sender, EventArgs e)
        {
            LimpiarControles_82CD();
            CambiarModo_82CD(ModoFrmAdmin_82CD.Añadir_82CD);
            txtDNI_82CD.Focus();
        }

        private void btnCancelar_82CD_Click(object sender, EventArgs e)
        {
            LimpiarControles_82CD();
            CambiarModo_82CD(ModoFrmAdmin_82CD.Consulta_82CD);
            CargarUsuarios_82CD();
        }

        private void btnAplicar_82CD_Click(object sender, EventArgs e)
        {

            var nuevoUsuario_82CD = new UsuarioBE_82CD
            {
                DNI_82CD = txtDNI_82CD.Text,
                Apellidos_82CD = txtApellidos_82CD.Text,
                Nombre_82CD = txtNombre_82CD.Text,
                Email_82CD = txtEmail_82CD.Text,
                IdRol_82CD = Convert.ToInt32(cmbRol_82CD.Text),
                LogIn_82CD = txtLogin_82CD.Text,
                Bloqueado_82CD = false,
                Activo_82CD = true,
            };

            try
            {
                string mensaje_82CD = bllUsuario_82CD.AgregarUsuario_82CD(nuevoUsuario_82CD);

                MessageBox.Show(mensaje_82CD);
                CargarUsuarios_82CD();
                CambiarModo_82CD(ModoFrmAdmin_82CD.Consulta_82CD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LimpiarControles_82CD();
        }

        private void btnSalir_82CD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


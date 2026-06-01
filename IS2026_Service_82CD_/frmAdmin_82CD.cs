using BLL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IS2026_Service_82CD_
{
    public partial class frmAdmin_82CD : Form
    {

        private BLLUsuario_82CD bllUsuario_82CD = new BLLUsuario_82CD();
        private BLLRol_82CD bllRol_82CD = new BLLRol_82CD();
        private ModoFrmAdmin_82CD modoActual_82CD = ModoFrmAdmin_82CD.Consulta_82CD;
        private ServicioUsuario_82CD usuarioseleccionado_82CD;

        public frmAdmin_82CD()
        {
            InitializeComponent();
        }

        private enum ModoFrmAdmin_82CD
        {
            Consulta_82CD,
            Añadir_82CD,
            Modificar_82CD,
            Eliminar_82CD,
            Desbloquear_82CD
        }

        private void frmAdmin_82CD_Load(object sender, EventArgs e)
        {
            LimpiarControles_82CD();
            CargarRoles_82CD();
            radbtnTodos_82CD.Checked = true;
            CambiarModo_82CD(ModoFrmAdmin_82CD.Consulta_82CD);
        }

        private void ActualizarDataGrid_82CD()
        {
            if (radbtnActivos_82CD.Checked)
                CargarUsuarios_82CD(true);
            else
                CargarUsuarios_82CD(false);
        }

        private void CargarRoles_82CD()
        {
            List<ServicioRol_82CD> roles_82CD = bllRol_82CD.ObtenerRoles_82CD();

            cmbRol_82CD.DataSource = roles_82CD;
            cmbRol_82CD.DisplayMember = "NombreRol_82CD";
            cmbRol_82CD.ValueMember = "IdRol_82CD";

            cmbRol_82CD.SelectedValue = 0;
        }

        private void CargarUsuarios_82CD(bool estado_82CD)
        {
            try
            {
                List<ServicioUsuario_82CD> usuarios_82CD = bllUsuario_82CD.ListarUsuario_82CD(estado_82CD);

                List<ServicioUsuario_82CD> listaMostrar_82CD = new List<ServicioUsuario_82CD>();

                foreach (ServicioUsuario_82CD u in usuarios_82CD)
                {
                    {
                        ServicioUsuario_82CD usuario_82CD = new ServicioUsuario_82CD();

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

                PintarUsuariosInactivos_82CD();

                lblCantUsuarios_82CD.Text = DGUsuarios_82CD.Rows.Count.ToString();
            }
            catch
            {
                CargarMensajes_82CD("Error al cargar usuarios");
            }
        }

        private void PintarUsuariosInactivos_82CD()
        {
            foreach(DataGridViewRow fila_82CD in DGUsuarios_82CD.Rows)
            {
                bool activo_82CD = Convert.ToBoolean(fila_82CD.Cells["Activo_82CD"].Value);

                if (!activo_82CD)
                {
                    fila_82CD.DefaultCellStyle.BackColor = Color.Red;
                    fila_82CD.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    fila_82CD.DefaultCellStyle.BackColor=Color.White;
                    fila_82CD.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void CambiarModo_82CD(ModoFrmAdmin_82CD modo_82CD)
        {
            modoActual_82CD = modo_82CD;

            switch (modo_82CD)
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


                case ModoFrmAdmin_82CD.Modificar_82CD:

                    lblDNI_82CD.Visible = false;
                    txtDNI_82CD.Visible = false;
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

                    CargarMensajes_82CD("Modo Modificar");

                    break;

                case ModoFrmAdmin_82CD.Eliminar_82CD:

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

                    btnCrear_82CD.Visible = false;
                    btnDesbloquear_82CD.Visible = false;
                    btnModificar_82CD.Visible = false;
                    btnActDesact_82CD.Visible = false;

                    btnAplicar_82CD.Visible = true;
                    btnCancelar_82CD.Visible = true;

                    CargarMensajes_82CD("Modo Eliminar");

                    break;

                case ModoFrmAdmin_82CD.Desbloquear_82CD:

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

                    btnCrear_82CD.Visible = false;
                    btnDesbloquear_82CD.Visible = false;
                    btnModificar_82CD.Visible = false;
                    btnActDesact_82CD.Visible = false;

                    btnAplicar_82CD.Visible = true;
                    btnCancelar_82CD.Visible = true;

                    CargarMensajes_82CD("Modo Desbloquear");

                    break;

            }
        }

        private void CargarMensajes_82CD(string texto_82CD)
        {
            rtbMensaje_82CD.Clear();
            rtbMensaje_82CD.AppendText(texto_82CD);
        }

        private void LimpiarControles_82CD()
        {
            txtDNI_82CD.Text = "";
            txtApellidos_82CD.Text = "";
            txtNombre_82CD.Text = "";
            txtEmail_82CD.Text = "";
            cmbRol_82CD.SelectedIndex = -1;
            txtLogin_82CD.Text = "";
            txtBloqueado_82CD.Text = "";
            txtActivo_82CD.Text = "";
        }

        private void btnCrear_82CD_Click(object sender, EventArgs e)
        {
            LimpiarControles_82CD();
            CambiarModo_82CD(ModoFrmAdmin_82CD.Añadir_82CD);
        }

        private void btnCancelar_82CD_Click(object sender, EventArgs e)
        {
            LimpiarControles_82CD();
            CambiarModo_82CD(ModoFrmAdmin_82CD.Consulta_82CD);
        }

        private void btnAplicar_82CD_Click(object sender, EventArgs e)
        {
            try
            {
                if (modoActual_82CD == ModoFrmAdmin_82CD.Añadir_82CD)
                {
                    if (String.IsNullOrEmpty(txtDNI_82CD.Text) || String.IsNullOrEmpty(txtApellidos_82CD.Text) || String.IsNullOrEmpty(txtNombre_82CD.Text) || String.IsNullOrEmpty(txtEmail_82CD.Text) || Convert.ToInt32(cmbRol_82CD.SelectedValue) == 0)
                    {
                        MessageBox.Show("Debe completar todos los campos para crear un usuario");
                        return;
                    }
                    else
                    {
                        var nuevoUsuario_82CD = new ServicioUsuario_82CD
                        {
                            DNI_82CD = txtDNI_82CD.Text,
                            Apellidos_82CD = txtApellidos_82CD.Text,
                            Nombre_82CD = txtNombre_82CD.Text,
                            Email_82CD = txtEmail_82CD.Text,
                            IdRol_82CD = Convert.ToInt32(cmbRol_82CD.SelectedValue),
                            Bloqueado_82CD = false,
                            Activo_82CD = true,
                        };

                        bllUsuario_82CD.AgregarUsuario_82CD(nuevoUsuario_82CD);

                        string passwordVista_82CD = nuevoUsuario_82CD.Apellidos_82CD.Replace(" ", "") + nuevoUsuario_82CD.DNI_82CD;

                        MessageBox.Show("Usuario creado correctamente" +
                        "\n Usuario: " + nuevoUsuario_82CD.LogIn_82CD +
                        "\n Contraseña: " + passwordVista_82CD);
                    }
                }

                if (modoActual_82CD == ModoFrmAdmin_82CD.Modificar_82CD)
                {
                    if (usuarioseleccionado_82CD == null)
                    {
                        MessageBox.Show("Debe seleccionar y modificar un usuario");
                        return;
                    }

                    if(usuarioseleccionado_82CD.Apellidos_82CD == txtApellidos_82CD.Text &&
                       usuarioseleccionado_82CD.Nombre_82CD == txtNombre_82CD.Text &&
                       usuarioseleccionado_82CD.Email_82CD == txtEmail_82CD.Text &&
                       usuarioseleccionado_82CD.IdRol_82CD == Convert.ToInt32(cmbRol_82CD.SelectedValue)
                       )
                    {
                        MessageBox.Show("Debe modificar al menos un dato del usuario");
                        return ;
                    }

                    usuarioseleccionado_82CD.Apellidos_82CD = txtApellidos_82CD.Text;
                    usuarioseleccionado_82CD.Nombre_82CD = txtNombre_82CD.Text;
                    usuarioseleccionado_82CD.Email_82CD = txtEmail_82CD.Text;
                    usuarioseleccionado_82CD.IdRol_82CD = Convert.ToInt32(cmbRol_82CD.SelectedValue);

                    bllUsuario_82CD.ModificarUsuario_82CD(usuarioseleccionado_82CD);
                    MessageBox.Show("Usuario modificado correctamente");
                }

                if (modoActual_82CD == ModoFrmAdmin_82CD.Eliminar_82CD)
                {
                    if (usuarioseleccionado_82CD == null)
                    {
                        MessageBox.Show("Debe seleccionar un usuario");
                        return;
                    }

                    if (usuarioseleccionado_82CD.Activo_82CD == true)
                    {
                        DialogResult confirmacion_82CD = MessageBox.Show("Desea desactivar al usuario: " + usuarioseleccionado_82CD.LogIn_82CD + "?",
                        "Confirmar desactivacion", MessageBoxButtons.YesNo);

                        if (confirmacion_82CD == DialogResult.No)
                        {
                            MessageBox.Show("Desactivacion cancelada");
                            return;
                        }

                        bllUsuario_82CD.CambiarEstadoUsuario_82CD(usuarioseleccionado_82CD, false);
                        MessageBox.Show($"El usuario: {usuarioseleccionado_82CD.LogIn_82CD} fue desactivado");
                    }
                    else
                    {
                        DialogResult confirmacion_82CD = MessageBox.Show("Desea activar al usuario: " + usuarioseleccionado_82CD.LogIn_82CD + "?",
                        "Confirmar activacion", MessageBoxButtons.YesNo);

                        if (confirmacion_82CD == DialogResult.No)
                        {
                            MessageBox.Show("Activacion cancelada");
                            return;
                        }
                        bllUsuario_82CD.CambiarEstadoUsuario_82CD(usuarioseleccionado_82CD, true);
                        MessageBox.Show($"El usuario: {usuarioseleccionado_82CD.LogIn_82CD} fue activado");
                    }
                }

                if (modoActual_82CD == ModoFrmAdmin_82CD.Desbloquear_82CD)
                {
                    if (usuarioseleccionado_82CD == null)
                    {
                        MessageBox.Show("Debe seleccionar un usuario");
                        return;
                    }
                    if (!usuarioseleccionado_82CD.Bloqueado_82CD)
                    {
                        MessageBox.Show("El usuario seleccionado no se encuentra bloqueado");
                        return;
                    }

                    DialogResult confirmacion_82CD = MessageBox.Show("Desea desbloquear al usuario: " + usuarioseleccionado_82CD.LogIn_82CD + "?",
                    "Confirmar desbloqueo", MessageBoxButtons.YesNo);

                    if(confirmacion_82CD == DialogResult.No)
                    {
                        MessageBox.Show("Desbloqueo cancelado");
                        return;
                    }
                    bllUsuario_82CD.DesbloquearUsuario_82CD(usuarioseleccionado_82CD);
                    MessageBox.Show("Se desbloqueo al usuario: " + usuarioseleccionado_82CD.LogIn_82CD +
                        "\n Y su contraseña fue blanqueada.");
                }
                usuarioseleccionado_82CD = null;
                ActualizarDataGrid_82CD();
                CambiarModo_82CD(ModoFrmAdmin_82CD.Consulta_82CD);
                LimpiarControles_82CD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSalir_82CD_Click(object sender, EventArgs e)
        {
            foreach(Form form_82CD in Application.OpenForms)
            {
                if (form_82CD is frmMenuPrincipal_82CD)
                {
                    form_82CD.Show();
                    break;
                }
            }
            this.Hide();
        }

        private void btnModificar_82CD_Click(object sender, EventArgs e)
        {
            LimpiarControles_82CD();
            CambiarModo_82CD(ModoFrmAdmin_82CD.Modificar_82CD);
            usuarioseleccionado_82CD = null;
        }

        private void DGUsuarios_82CD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = DGUsuarios_82CD.Rows[e.RowIndex];

            usuarioseleccionado_82CD = new ServicioUsuario_82CD
            {
                DNI_82CD = row.Cells["DNI_82CD"].Value.ToString(),
                Apellidos_82CD = row.Cells["Apellidos_82CD"].Value.ToString(),
                Nombre_82CD = row.Cells["Nombre_82CD"].Value.ToString(),
                Email_82CD = row.Cells["Email_82CD"].Value.ToString(),
                IdRol_82CD = Convert.ToInt32(row.Cells["IdRol_82CD"].Value.ToString()),
                LogIn_82CD = row.Cells["LogIn_82CD"].Value.ToString(),
                Bloqueado_82CD = Convert.ToBoolean(row.Cells["Bloqueado_82CD"].Value),
                Activo_82CD = Convert.ToBoolean(row.Cells["Activo_82CD"].Value),
            };

            txtDNI_82CD.Text = usuarioseleccionado_82CD.DNI_82CD;
            txtApellidos_82CD.Text = usuarioseleccionado_82CD.Apellidos_82CD;
            txtNombre_82CD.Text = usuarioseleccionado_82CD.Nombre_82CD;
            txtEmail_82CD.Text = usuarioseleccionado_82CD.Email_82CD;
            cmbRol_82CD.SelectedValue = usuarioseleccionado_82CD.IdRol_82CD;
        }

        private void btnActDesact_82CD_Click(object sender, EventArgs e)
        {
            CambiarModo_82CD(ModoFrmAdmin_82CD.Eliminar_82CD);
            usuarioseleccionado_82CD = null;
        }


        private void radbtnTodos_82CD_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDataGrid_82CD();
        }

        private void radbtnActivos_82CD_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDataGrid_82CD();
        }

        private void btnDesbloquear_82CD_Click(object sender, EventArgs e)
        {
            CambiarModo_82CD(ModoFrmAdmin_82CD.Desbloquear_82CD);
            usuarioseleccionado_82CD = null;
        }

    }
}


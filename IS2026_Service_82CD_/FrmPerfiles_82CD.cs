using BLL;
using Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS2026_Service_82CD_
{
    public partial class FrmPerfiles_82CD : Form
    {
        public FrmPerfiles_82CD()
        {
            InitializeComponent();
        }

        private BLLRol_82CD bllRol_82CD = new BLLRol_82CD();
        private BLLFamilia_82CD bllFamilia_82CD = new BLLFamilia_82CD();
        private BLLPermiso_82CD bllPermiso_82CD = new BLLPermiso_82CD();
        private ModoFrmPerfiles_82CD modoActual_82CD = ModoFrmPerfiles_82CD.Consulta_82CD;
        private bool seleccionDesdeArbol_82CD = false;
        private object elementoSeleccionadoArbol_82CD = null;
        private bool pausarEventos_82CD;

        private enum ModoFrmPerfiles_82CD
        {
            Consulta_82CD,
            CrearRol_82CD,
            CrearFamilia_82CD,
            ModificarRol_82CD,
            ModificarFamilia_82CD
        }

        private void FrmPerfiles_82CD_Load(object sender, EventArgs e)
        {
            LimpiarControles_82CD();
            radbtnRoles_82CD.Checked = true;
            CargarListBox_82CD();
            CambiarModo_82CD(ModoFrmPerfiles_82CD.Consulta_82CD);
        }

        private void CargarListBox_82CD()
        {
            List<IElementoPermiso_82CD> elementos_82CD = new List<IElementoPermiso_82CD>();

            foreach (ServicioPermiso_82CD permiso_82CD in bllPermiso_82CD.ListarPermisos_82CD())
            {
                elementos_82CD.Add(permiso_82CD);
            }

            foreach (ServicioFamilia_82CD familia_82CD in bllFamilia_82CD.ListarFamilias_82CD())
            {
                elementos_82CD.Add(familia_82CD);
            }

            lstPeFam_82CD.DataSource = elementos_82CD;
            lstPeFam_82CD.DisplayMember = "Nombre_82CD";
            lstPeFam_82CD.ClearSelected();
        }

        private void CargarCombo_82CD()
        {
            pausarEventos_82CD = true;

            if (radbtnRoles_82CD.Checked)
            {
                lblRolFam_82CD.Text = "Rol";
                cmbRolFam_82CD.DataSource = bllRol_82CD.ObtenerRoles_82CD();
                cmbRolFam_82CD.DisplayMember = "NombreRol_82CD";
                cmbRolFam_82CD.ValueMember = "IdRol_82CD";
            }
            else
            {
                lblRolFam_82CD.Text = "Familia";
                cmbRolFam_82CD.DataSource = bllFamilia_82CD.ListarFamilias_82CD();
                cmbRolFam_82CD.DisplayMember = "Nombre_82CD";
                cmbRolFam_82CD.ValueMember = "IdFamilia_82CD";
            }

            pausarEventos_82CD = false;

            if (cmbRolFam_82CD.Items.Count > 0)
            {
                cmbRolFam_82CD.SelectedIndex = 0;
            }
            else
            {
                treeFamRol_82CD.Nodes.Clear();
            }
        }


        private void CambiarModo_82CD(ModoFrmPerfiles_82CD modo_82CD)
        {
            modoActual_82CD = modo_82CD;

            switch (modo_82CD)
            {
                case ModoFrmPerfiles_82CD.Consulta_82CD:

                    radbtnRoles_82CD.Visible = true;
                    radbtnFamilias_82CD.Visible = true;
                    cmbRolFam_82CD.Visible = true;
                    lblRolFam_82CD.Visible = true;

                    lblNombre_82CD.Visible = false;
                    txtNombre_82CD.Visible = false;

                    btnCrear_82CD.Visible = true;
                    btnEliminar_82CD.Visible = true;
                    btnAplicar_82CD.Visible = false;
                    btnCancelar_82CD.Visible = false;
                    btnModificar_82CD.Visible = true;

                    lstPeFam_82CD.Enabled = false;

                    CargarMensaje_82CD("Modo Consulta");
                    CargarCombo_82CD();

                    break;

                case ModoFrmPerfiles_82CD.CrearRol_82CD:

                    radbtnRoles_82CD.Visible = false;
                    radbtnFamilias_82CD.Visible = false;
                    cmbRolFam_82CD.Visible = false;
                    lblRolFam_82CD.Visible = false;

                    lblNombre_82CD.Visible = true;
                    txtNombre_82CD.Visible = true;

                    btnCrear_82CD.Visible = false;
                    btnEliminar_82CD.Visible = false;
                    btnAplicar_82CD.Visible = true;
                    btnCancelar_82CD.Visible = true;
                    btnModificar_82CD.Visible = false;

                    lstPeFam_82CD.Enabled = true;

                    CargarMensaje_82CD("Modo Crear Rol");
                    ActualizarArbol_82CD();

                    break;

                case ModoFrmPerfiles_82CD.CrearFamilia_82CD:

                    radbtnRoles_82CD.Visible = false;
                    radbtnFamilias_82CD.Visible = false;
                    cmbRolFam_82CD.Visible = false;
                    lblRolFam_82CD.Visible = false;

                    lblNombre_82CD.Visible = true;
                    txtNombre_82CD.Visible = true;

                    btnCrear_82CD.Visible = false;
                    btnEliminar_82CD.Visible = false;
                    btnAplicar_82CD.Visible = true;
                    btnCancelar_82CD.Visible = true;
                    btnModificar_82CD.Visible = false;

                    lstPeFam_82CD.Enabled = true;

                    CargarMensaje_82CD("Modo Crear Familia");
                    ActualizarArbol_82CD();

                    break;

                case ModoFrmPerfiles_82CD.ModificarRol_82CD:
                    radbtnRoles_82CD.Visible = true;
                    radbtnFamilias_82CD.Visible = true;
                    cmbRolFam_82CD.Visible = true;
                    lblRolFam_82CD.Visible = true;

                    lblNombre_82CD.Visible = false;
                    txtNombre_82CD.Visible = false;

                    btnCrear_82CD.Visible = false;
                    btnEliminar_82CD.Visible = false;
                    btnModificar_82CD.Visible = false;
                    btnAplicar_82CD.Visible = true;
                    btnCancelar_82CD.Visible = true;

                    lstPeFam_82CD.Enabled = true;
                    lstPeFam_82CD.ClearSelected();

                    if (cmbRolFam_82CD.SelectedValue != null)
                    {
                        MostrarArbolRol_82CD(Convert.ToInt32(cmbRolFam_82CD.SelectedValue));
                    }

                    CargarMensaje_82CD("Modo Modificar Rol");
                    break;

                case ModoFrmPerfiles_82CD.ModificarFamilia_82CD:

                    radbtnRoles_82CD.Visible = true;
                    radbtnFamilias_82CD.Visible = true;
                    cmbRolFam_82CD.Visible = true;
                    lblRolFam_82CD.Visible = true;

                    lblNombre_82CD.Visible = false;
                    txtNombre_82CD.Visible = false;

                    btnCrear_82CD.Visible = false;
                    btnEliminar_82CD.Visible = false;
                    btnModificar_82CD.Visible = false;
                    btnAplicar_82CD.Visible = true;
                    btnCancelar_82CD.Visible = true;

                    lstPeFam_82CD.Enabled = true;
                    lstPeFam_82CD.ClearSelected();

                    if (cmbRolFam_82CD.SelectedValue != null)
                    {
                        MostrarArbolFamilia_82CD(Convert.ToInt32(cmbRolFam_82CD.SelectedValue));
                    }

                    CargarMensaje_82CD("Modo Modificar Familia");
                    break;


            }
        }

        private void CargarMensaje_82CD(string texto_82CD)
        {
            rbtMensaje_82CD.Clear();
            rbtMensaje_82CD.AppendText(texto_82CD);
        }

        private void ActualizarArbol_82CD()
        {
            treeFamRol_82CD.Nodes.Clear();

            string nombreRaiz_82CD = string.Empty;

            if (modoActual_82CD == ModoFrmPerfiles_82CD.CrearFamilia_82CD)
            {
                nombreRaiz_82CD = "Nueva Familia";
            }
            else
            {
                nombreRaiz_82CD = "Nuevo Rol";
            }

            TreeNode Raiz_82CD = new TreeNode(nombreRaiz_82CD);

            foreach (object item_82CD in lstPeFam_82CD.SelectedItems)
            {
                ServicioPermiso_82CD permiso_82CD = item_82CD as ServicioPermiso_82CD;

                if (permiso_82CD != null)
                {
                    Raiz_82CD.Nodes.Add(new TreeNode("[Permiso] " + permiso_82CD.Nombre_82CD));
                    continue;
                }

                ServicioFamilia_82CD familiaSel_82CD = item_82CD as ServicioFamilia_82CD;
                if (familiaSel_82CD != null)
                {
                    ServicioFamilia_82CD familiaConArbol_82CD = bllFamilia_82CD.CargarFamilia_82CD(familiaSel_82CD.IdFamilia_82CD);
                    if (familiaConArbol_82CD != null)
                    {
                        Raiz_82CD.Nodes.Add(CrearNodo_82CD(familiaConArbol_82CD));
                    }
                }
            }
            treeFamRol_82CD.Nodes.Add(Raiz_82CD);
            Raiz_82CD.ExpandAll();
        }


        private void LimpiarControles_82CD()
        {
            txtNombre_82CD.Text = "";
            treeFamRol_82CD.Nodes.Clear();
            lstPeFam_82CD.ClearSelected();
        }

        private void cmbRolFam_82CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pausarEventos_82CD)
            {
                return;
            }

            try
            {
                int id_82CD = Convert.ToInt32(cmbRolFam_82CD.SelectedValue);
                if (radbtnRoles_82CD.Checked)
                {
                    MostrarArbolRol_82CD(id_82CD);
                }

                else
                {
                    MostrarArbolFamilia_82CD(id_82CD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void MostrarArbolRol_82CD(int idRol_82CD)
        {
            ServicioRol_82CD rol_82CD = bllRol_82CD.CargarRol_82CD(idRol_82CD);

            treeFamRol_82CD.Nodes.Clear();
            TreeNode Raiz_82CD = new TreeNode(rol_82CD.NombreRol_82CD);
            Raiz_82CD.Tag = rol_82CD;

            foreach (IElementoPermiso_82CD elemento_82CD in rol_82CD.Elementos_82CD)
            {
                Raiz_82CD.Nodes.Add(CrearNodo_82CD(elemento_82CD));
            }

            treeFamRol_82CD.Nodes.Add(Raiz_82CD);
            Raiz_82CD.ExpandAll();
        }


        private void MostrarArbolFamilia_82CD(int idFamilia_82CD)
        {
            ServicioFamilia_82CD familia_82CD = bllFamilia_82CD.CargarFamilia_82CD(idFamilia_82CD);

            treeFamRol_82CD.Nodes.Clear();
            TreeNode Raiz_82CD = new TreeNode(familia_82CD.Nombre_82CD);
            Raiz_82CD.Tag = familia_82CD;

            foreach (IElementoPermiso_82CD elemento_82CD in familia_82CD.Elementos_82CD)
            {
                Raiz_82CD.Nodes.Add(CrearNodo_82CD(elemento_82CD));
            }

            treeFamRol_82CD.Nodes.Add(Raiz_82CD);
            Raiz_82CD.ExpandAll();
        }


        private TreeNode CrearNodo_82CD(IElementoPermiso_82CD elemento_82CD)
        {
            ServicioPermiso_82CD permiso_82CD = elemento_82CD as ServicioPermiso_82CD;
            if (permiso_82CD != null)
            {
                TreeNode nodoPermiso_82CD = new TreeNode("[Permiso] " + permiso_82CD.Nombre_82CD);
                nodoPermiso_82CD.Tag = permiso_82CD;
                return nodoPermiso_82CD;
            }

            ServicioFamilia_82CD familia_82CD = elemento_82CD as ServicioFamilia_82CD;
            TreeNode nodoFamilia_82CD = new TreeNode(familia_82CD.Nombre_82CD);
            nodoFamilia_82CD.Tag = familia_82CD;

            foreach (IElementoPermiso_82CD hijo_82CD in familia_82CD.Elementos_82CD)
            {
                nodoFamilia_82CD.Nodes.Add(CrearNodo_82CD(hijo_82CD));
            }

            return nodoFamilia_82CD;
        }

        private void lstPeFam_82CD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modoActual_82CD == ModoFrmPerfiles_82CD.CrearRol_82CD || modoActual_82CD == ModoFrmPerfiles_82CD.CrearFamilia_82CD)
                ActualizarArbol_82CD();
        }

        private void radbtnRoles_82CD_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnRoles_82CD.Checked)
                CargarCombo_82CD();
        }

        private void radbtnFamilias_82CD_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnFamilias_82CD.Checked)
                CargarCombo_82CD();
        }

        private void btnCrear_82CD_Click(object sender, EventArgs e)
        {
            LimpiarControles_82CD();

            if (radbtnRoles_82CD.Checked)
            {
                CambiarModo_82CD(ModoFrmPerfiles_82CD.CrearRol_82CD);
            }
            else
            {
                CambiarModo_82CD(ModoFrmPerfiles_82CD.CrearFamilia_82CD);
            }
        }

        private void btnAplicar_82CD_Click(object sender, EventArgs e)
        {
            try
            {
                if (modoActual_82CD == ModoFrmPerfiles_82CD.CrearRol_82CD)
                {
                    if (String.IsNullOrEmpty(txtNombre_82CD.Text))
                    {
                        MessageBox.Show("Debe ingresar un nombre para el Rol");
                        return;
                    }

                    if (lstPeFam_82CD.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar al menos un permiso o familia");
                        return;
                    }

                    ServicioRol_82CD rol_82CD = new ServicioRol_82CD();
                    rol_82CD.NombreRol_82CD = txtNombre_82CD.Text;

                    foreach (object item_82CD in lstPeFam_82CD.SelectedItems)
                    {
                        ServicioPermiso_82CD permiso_82CD = item_82CD as ServicioPermiso_82CD;
                        if (permiso_82CD != null)
                        {
                            rol_82CD.PermisosSeleccionados_82CD.Add(permiso_82CD);
                        }
                        else
                        {
                            ServicioFamilia_82CD familia_82CD = item_82CD as ServicioFamilia_82CD;
                            if (familia_82CD != null)
                            {
                                rol_82CD.FamiliasSeleccionadas_82CD.Add(familia_82CD);
                            }
                        }
                    }
                    bllRol_82CD.CrearRol_82CD(rol_82CD);
                    MessageBox.Show("Rol creado correctamente");
                }


                if (modoActual_82CD == ModoFrmPerfiles_82CD.CrearFamilia_82CD)
                {
                    if (String.IsNullOrEmpty(txtNombre_82CD.Text))
                    {
                        MessageBox.Show("Debe ingresar un nombre para la Familia");
                        return;
                    }

                    if (lstPeFam_82CD.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar al menos un permiso o familia");
                        return;
                    }

                    ServicioFamilia_82CD familia_82CD = new ServicioFamilia_82CD();
                    familia_82CD.Nombre_82CD = txtNombre_82CD.Text;

                    foreach (object item_82CD in lstPeFam_82CD.SelectedItems)
                    {
                        ServicioPermiso_82CD permiso_82CD = item_82CD as ServicioPermiso_82CD;
                        if (permiso_82CD != null)
                        {
                            familia_82CD.permisosSeleccionados_82CD.Add(permiso_82CD);
                        }
                        else
                        {
                            ServicioFamilia_82CD subfamilia_82CD = item_82CD as ServicioFamilia_82CD;
                            if (subfamilia_82CD != null)
                            {
                                familia_82CD.familiasSeleccionadas_82CD.Add(subfamilia_82CD);
                            }
                        }
                    }
                    bllFamilia_82CD.CrearFamilia_82CD(familia_82CD);
                    MessageBox.Show("Familia creada correctamente");
                }

                if (modoActual_82CD == ModoFrmPerfiles_82CD.ModificarRol_82CD)
                {
                    ServicioRol_82CD rol_82CD = cmbRolFam_82CD.SelectedItem as ServicioRol_82CD;

                    if (rol_82CD == null)
                    {
                        MessageBox.Show("Debe seleccionar un rol");
                        return;
                    }

                    if (lstPeFam_82CD.SelectedItem == null)
                    {
                        MessageBox.Show("Debe seleccionar un permiso o familia");
                        return;
                    }

                    ServicioPermiso_82CD permiso_82CD = lstPeFam_82CD.SelectedItem as ServicioPermiso_82CD;

                    if (permiso_82CD != null)
                    {
                        if (seleccionDesdeArbol_82CD)
                        {
                            bllRol_82CD.QuitarPermisoARol_82CD(rol_82CD.IdRol_82CD, permiso_82CD.IdPermiso_82CD);
                            MessageBox.Show("Permiso quitado correctamente");
                        }
                        else
                        {
                            if (bllRol_82CD.RolTienePermiso_82CD(rol_82CD.IdRol_82CD, permiso_82CD.IdPermiso_82CD))
                            {
                                MessageBox.Show("El rol ya tiene ese permiso");
                                return;
                            }
                            bllRol_82CD.ValidarPermisoParaAgregarARol_82CD(rol_82CD.IdRol_82CD, permiso_82CD);

                            bllRol_82CD.AgregarPermisoARol_82CD(rol_82CD.IdRol_82CD, permiso_82CD.IdPermiso_82CD);
                            MessageBox.Show("Permiso agregado correctamente");
                        }
                    }

                    ServicioFamilia_82CD familia_82CD = lstPeFam_82CD.SelectedItem as ServicioFamilia_82CD;

                    if (familia_82CD != null)
                    {
                        if (seleccionDesdeArbol_82CD)
                        {
                            bllRol_82CD.QuitarFamiliaARol_82CD(rol_82CD.IdRol_82CD, familia_82CD.IdFamilia_82CD);
                            MessageBox.Show("Familia quitada correctamente");
                        }
                        else
                        {
                            if (bllRol_82CD.RolTieneFamilia_82CD(rol_82CD.IdRol_82CD, familia_82CD.IdFamilia_82CD))
                            {
                                MessageBox.Show("El rol ya tiene esa familia");
                                return;
                            }

                            bllRol_82CD.ValidarFamiliaParaAgregarARol_82CD(rol_82CD.IdRol_82CD, familia_82CD);

                            bllRol_82CD.AgregarFamiliaARol_82CD(rol_82CD.IdRol_82CD, familia_82CD.IdFamilia_82CD);
                            MessageBox.Show("Familia agregada correctamente");
                        }
                    }

                    seleccionDesdeArbol_82CD = false;
                    elementoSeleccionadoArbol_82CD = null;

                    LimpiarControles_82CD();
                    CambiarModo_82CD(ModoFrmPerfiles_82CD.Consulta_82CD);
                    return;
                }

                if (modoActual_82CD == ModoFrmPerfiles_82CD.ModificarFamilia_82CD)
                {
                    ServicioFamilia_82CD familiaActual_82CD = cmbRolFam_82CD.SelectedItem as ServicioFamilia_82CD;

                    if (familiaActual_82CD == null)
                    {
                        MessageBox.Show("Debe seleccionar una familia");
                        return;
                    }

                    if (lstPeFam_82CD.SelectedItem == null)
                    {
                        MessageBox.Show("Debe seleccionar un permiso o familia");
                        return;
                    }

                    ServicioPermiso_82CD permiso_82CD = lstPeFam_82CD.SelectedItem as ServicioPermiso_82CD;

                    if (permiso_82CD != null)
                    {
                        if (seleccionDesdeArbol_82CD)
                        {
                            bllFamilia_82CD.QuitarPermisoAFamilia_82CD(familiaActual_82CD.IdFamilia_82CD, permiso_82CD.IdPermiso_82CD);
                            MessageBox.Show("Permiso quitado correctamente");
                        }
                        else
                        {
                            if (bllFamilia_82CD.FamiliaTienePermiso_82CD(familiaActual_82CD.IdFamilia_82CD, permiso_82CD.IdPermiso_82CD))
                            {
                                MessageBox.Show("La familia ya tiene ese permiso");
                                return;
                            }

                            bllFamilia_82CD.ValidarPermisoParaAgregarAFamilia_82CD(familiaActual_82CD.IdFamilia_82CD, permiso_82CD);
                            bllFamilia_82CD.AgregarPermisoAFamilia_82CD(familiaActual_82CD.IdFamilia_82CD, permiso_82CD.IdPermiso_82CD);

                            MessageBox.Show("Permiso agregado correctamente");
                        }
                    }

                    ServicioFamilia_82CD subfamilia_82CD = lstPeFam_82CD.SelectedItem as ServicioFamilia_82CD;

                    if (subfamilia_82CD != null)
                    {
                        if (seleccionDesdeArbol_82CD)
                        {
                            bllFamilia_82CD.QuitarSubfamiliaAFamilia_82CD(familiaActual_82CD.IdFamilia_82CD, subfamilia_82CD.IdFamilia_82CD);
                            MessageBox.Show("Familia quitada correctamente");
                        }
                        else
                        {
                            if (bllFamilia_82CD.FamiliaTieneSubfamilia_82CD(familiaActual_82CD.IdFamilia_82CD, subfamilia_82CD.IdFamilia_82CD))
                            {
                                MessageBox.Show("La familia ya contiene esa familia");
                                return;
                            }

                            bllFamilia_82CD.ValidarSubfamiliaParaAgregarAFamilia_82CD(familiaActual_82CD.IdFamilia_82CD, subfamilia_82CD);
                            bllFamilia_82CD.AgregarSubfamiliaAFamilia_82CD(familiaActual_82CD.IdFamilia_82CD, subfamilia_82CD.IdFamilia_82CD);

                            MessageBox.Show("Familia agregada correctamente");
                        }
                    }

                    seleccionDesdeArbol_82CD = false;
                    elementoSeleccionadoArbol_82CD = null;

                    LimpiarControles_82CD();
                    CambiarModo_82CD(ModoFrmPerfiles_82CD.Consulta_82CD);
                    return;
                }

                LimpiarControles_82CD();
                CambiarModo_82CD(ModoFrmPerfiles_82CD.Consulta_82CD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_82CD_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion_82CD = MessageBox.Show("¿Desea cancelar? Se perderan todos los cambios.",
            "Confirmar cancelación", MessageBoxButtons.YesNo);

            if (confirmacion_82CD == DialogResult.No)
            {
                return;
            }
            else
            {
                LimpiarControles_82CD();
                CambiarModo_82CD(ModoFrmPerfiles_82CD.Consulta_82CD);
            }
        }

        private void btnEliminar_82CD_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRolFam_82CD.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar el elemento que desea eliminar");
                    return;
                }

                int id_82CD = Convert.ToInt32(cmbRolFam_82CD.SelectedValue);

                if (radbtnRoles_82CD.Checked)
                {
                    DialogResult confirmacion_82CD = MessageBox.Show("¿Desea eliminar el rol seleccionado?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo);

                    if (confirmacion_82CD == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        ServicioRol_82CD rol_82CD = new ServicioRol_82CD();
                        rol_82CD.IdRol_82CD = id_82CD;
                        bllRol_82CD.EliminarRol_82CD(rol_82CD);
                        MessageBox.Show("Rol eliminado correctamente");
                    }
                }
                else
                {
                    DialogResult confirmacion_82CD = MessageBox.Show("¿Desea eliminar la familia seleccionada?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo);

                    if (confirmacion_82CD == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        ServicioFamilia_82CD familia_82CD = new ServicioFamilia_82CD();
                        familia_82CD.IdFamilia_82CD = id_82CD;
                        bllFamilia_82CD.EliminarFamilia_82CD(familia_82CD);
                        MessageBox.Show("Familia eliminada correctamente");
                    }
                }

                CambiarModo_82CD(ModoFrmPerfiles_82CD.Consulta_82CD);
            }
            catch (Exception ex)
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

        private void btnModificar_82CD_Click(object sender, EventArgs e)
        {
            if(cmbRolFam_82CD.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un rol o familia");
                return;
            }

            if (radbtnRoles_82CD.Checked)
            {
                CambiarModo_82CD(ModoFrmPerfiles_82CD.ModificarRol_82CD);
            }
            else
            {
                CambiarModo_82CD(ModoFrmPerfiles_82CD.ModificarFamilia_82CD);
            }
        }

        private void treeFamRol_82CD_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (modoActual_82CD != ModoFrmPerfiles_82CD.ModificarRol_82CD &&
               modoActual_82CD != ModoFrmPerfiles_82CD.ModificarFamilia_82CD)
            {
                return;
            }

            if (e.Node.Tag == null)
            {
                return;
            }

            elementoSeleccionadoArbol_82CD = e.Node.Tag;
            seleccionDesdeArbol_82CD = true;

            lstPeFam_82CD.ClearSelected();

            for (int i = 0; i < lstPeFam_82CD.Items.Count; i++)
            {
                object item_82CD = lstPeFam_82CD.Items[i];

                ServicioPermiso_82CD permisoLista_82CD = item_82CD as ServicioPermiso_82CD;
                ServicioPermiso_82CD permisoNodo_82CD = e.Node.Tag as ServicioPermiso_82CD;

                if (permisoLista_82CD != null && permisoNodo_82CD != null &&
                    permisoLista_82CD.IdPermiso_82CD == permisoNodo_82CD.IdPermiso_82CD)
                {
                    lstPeFam_82CD.SetSelected(i, true);
                    return;
                }

                ServicioFamilia_82CD familiaLista_82CD = item_82CD as ServicioFamilia_82CD;
                ServicioFamilia_82CD familiaNodo_82CD = e.Node.Tag as ServicioFamilia_82CD;

                if (familiaLista_82CD != null && familiaNodo_82CD != null &&
                    familiaLista_82CD.IdFamilia_82CD == familiaNodo_82CD.IdFamilia_82CD)
                {
                    lstPeFam_82CD.SetSelected(i, true);
                    return;
                }
            }
        }
    }
}

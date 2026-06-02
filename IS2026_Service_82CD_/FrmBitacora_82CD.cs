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
    public partial class FrmBitacora_82CD : Form
    {
        private BLLEvento_82CD bllEvento_82CD = new BLLEvento_82CD();
        private BLLUsuario_82CD bllUsuario_82CD = new BLLUsuario_82CD();
        private ServicioEvento_82CD eventoSeleccionado_82CD = null;

        public FrmBitacora_82CD()
        {
            InitializeComponent();
        }

        private void FrmBitacora_82CD_Load(object sender, EventArgs e)
        {
            CargarCombos_82CD();
            CargarGrilla_82CD(bllEvento_82CD.ObtenerEventosUlt3Dias_82CD()); ;
        }

        private void CargarCombos_82CD()
        {
            cmbLogin_82CD.Items.Clear();
            cmbLogin_82CD.Items.Add("");
            List<ServicioUsuario_82CD> listausuarios_82CD = bllUsuario_82CD.ListarUsuario_82CD(false);
            foreach (ServicioUsuario_82CD usuario_82CD in listausuarios_82CD)
            {
                cmbLogin_82CD.Items.Add(usuario_82CD.LogIn_82CD);
            }
            cmbLogin_82CD.SelectedIndex = 0;

            cmbModulo_82CD.Items.Clear();
            cmbModulo_82CD.Items.Add("");
            cmbModulo_82CD.Items.Add("Login");
            cmbModulo_82CD.Items.Add("Admin");
            cmbModulo_82CD.Items.Add("Usuario");
            cmbModulo_82CD.SelectedIndex = 0;

            cmbEvento_82CD.Items.Clear();
            cmbEvento_82CD.Items.Add("");
            cmbEvento_82CD.Items.Add("Crear Usuario");
            cmbEvento_82CD.Items.Add("Iniciar Sesión");
            cmbEvento_82CD.Items.Add("Bloquear Usuario");
            cmbEvento_82CD.Items.Add("Desbloquear Usuario");
            cmbEvento_82CD.Items.Add("Modificar Usuario");
            cmbEvento_82CD.Items.Add("Cambiar Contraseña");
            cmbEvento_82CD.Items.Add("Cerrar Sesión");
            cmbEvento_82CD.Items.Add("Activar Usuario");
            cmbEvento_82CD.Items.Add("Desactivar Usuario");
            cmbEvento_82CD.SelectedIndex = 0;

            cmbCriticidad_82CD.Items.Clear();
            cmbCriticidad_82CD.Items.Add("");
            cmbCriticidad_82CD.Items.Add("1");
            cmbCriticidad_82CD.Items.Add("2");
            cmbCriticidad_82CD.Items.Add("3");
            cmbCriticidad_82CD.Items.Add("4");
            cmbCriticidad_82CD.Items.Add("5");
            cmbCriticidad_82CD.SelectedIndex = 0;

            DaTimeFechaInicial_82CD.Value = DateTime.Today.AddDays(-3);
            
            DaTimeFechaFinal_82CD.Value = DateTime.Today;
        }

        private void CargarGrilla_82CD(List<ServicioEvento_82CD> lista_82CD)
        {
            if (lista_82CD.Count > 0)
            {
                DGBitacora_82CD.DataSource = lista_82CD;

                foreach(ServicioEvento_82CD evento_82CD in lista_82CD)
                {
                    eventoSeleccionado_82CD = evento_82CD;
                    break;
                }

                MostrarNombreApellido_82CD(eventoSeleccionado_82CD.LogIn_82CD);
            }
            else
            {
                MessageBox.Show("No se encontraron eventos");
            }
        }

        private void btnLimpiar_82CD_Click(object sender, EventArgs e)
        {
            cmbLogin_82CD.SelectedIndex = 0;
            cmbModulo_82CD.SelectedIndex = 0;
            cmbEvento_82CD.SelectedIndex = 0;
            cmbCriticidad_82CD.SelectedIndex = 0;
            DaTimeFechaInicial_82CD.Value = DateTime.Today.AddDays(-3);
            DaTimeFechaFinal_82CD.Value = DateTime.Today;

            CargarGrilla_82CD(bllEvento_82CD.ObtenerEventosUlt3Dias_82CD());
        }

        private void btnAplicar_82CD_Click(object sender, EventArgs e)
        {
            try
            {
                string login_82CD = null;
                string modulo_82CD = null;
                string evento_82CD = null;
                int criticidad_82CD = -1;

                if (cmbLogin_82CD.SelectedItem != null && cmbLogin_82CD.SelectedItem.ToString() != "")
                    login_82CD = cmbLogin_82CD.SelectedItem.ToString();

                if (cmbModulo_82CD.SelectedItem != null && cmbModulo_82CD.SelectedItem.ToString() != "")
                    modulo_82CD = cmbModulo_82CD.SelectedItem.ToString();

                if (cmbEvento_82CD.SelectedItem != null && cmbEvento_82CD.SelectedItem.ToString() != "")
                    evento_82CD = cmbEvento_82CD.SelectedItem.ToString();

                if (cmbCriticidad_82CD.SelectedItem != null && cmbCriticidad_82CD.SelectedItem.ToString() != "")
                    criticidad_82CD = Convert.ToInt32(cmbCriticidad_82CD.SelectedItem.ToString());

                DateTime fechaInicial_82CD = DaTimeFechaInicial_82CD.Value.Date;
                DateTime fechaFinal_82CD = DaTimeFechaFinal_82CD.Value.Date;

                if (fechaInicial_82CD > fechaFinal_82CD)
                {
                    MessageBox.Show("La fecha final no puede ser anterior a la fecha inicial.");
                    return;
                }

                List<ServicioEvento_82CD> eventosfiltrados_82CD = bllEvento_82CD.FiltrarEventos_82CD(login_82CD, fechaInicial_82CD, fechaFinal_82CD , evento_82CD, modulo_82CD, criticidad_82CD);
                CargarGrilla_82CD(eventosfiltrados_82CD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImprimir_82CD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos trabajando en eso ;)");
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

        private void MostrarNombreApellido_82CD(string login_82CD)
        {
            //MapperUsuario_82CD.BuscarUsuarioPorLogin_82CD(login_82CD)  Se podria crear el metodo en bllusuario solo para usarlo aca o generamos acoplamiento?

            ServicioUsuario_82CD usuario_82CD = bllEvento_82CD.BuscarUsuarioEvento_82CD(login_82CD);

            if(usuario_82CD != null)
            {
                lblUSeleccNombre_82CD.Text = usuario_82CD.Nombre_82CD;
                lblUSeleccApellido_82CD.Text = usuario_82CD.Apellidos_82CD;
            }
            else
            {
                MessageBox.Show("Error al cargar usuario del evento seleccionado");
            }
        }

        private void DGBitacora_82CD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow rows_82CD = DGBitacora_82CD.Rows[e.RowIndex];

            eventoSeleccionado_82CD = new ServicioEvento_82CD
            {
                IDEvento_82CD = Convert.ToInt32(rows_82CD.Cells["IDEvento_82CD"].Value),
                LogIn_82CD = rows_82CD.Cells["LogIn_82CD"].Value.ToString(),
                Fecha_82CD = Convert.ToDateTime(rows_82CD.Cells["Fecha_82CD"].Value),
                Hora_82CD = (TimeSpan)rows_82CD.Cells["Hora_82CD"].Value,
                Modulo_82CD = rows_82CD.Cells["Modulo_82CD"].Value.ToString(),
                Evento_82CD = rows_82CD.Cells["Evento_82CD"].Value.ToString(),
                Criticidad_82CD = Convert.ToInt32(rows_82CD.Cells["Criticidad_82CD"].Value),
            };

            MostrarNombreApellido_82CD(eventoSeleccionado_82CD.LogIn_82CD);
        }

    }
}

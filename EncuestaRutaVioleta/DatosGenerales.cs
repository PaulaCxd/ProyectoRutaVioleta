using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Negocio;
using Entidades;


namespace EncuestaRutaVioleta
{
    public partial class DatosGenerales : Form
    {
        public static RutaVioleta RutaVioleta = new RutaVioleta();
        private IServicioRutaVioleta servicioRutaVioleta;
        private IServicioMaestro servicioMaestro;
        private string PrimerNombre;
        private string SegundoNombre;
        private string PrimerApellido;
        private string SegundoApellido;
        private Sexo Sexo;
        private TipoDocumento TipoDocumento;
        private string NumeroDocumento;
        private DateTime FechaNacimiento;
        private Departamento Departamento;
        private Municipio MunicipioResidencia;
        private Orientacion OrientacionSexual;
        private IdentidadGenero Identidad;
        private Sede Sede;
        private Facultad Facultad;
        public DatosGenerales()
        {
            InitializeComponent();
            servicioRutaVioleta = new ServicioRutaVioleta();
            servicioMaestro = new ServicioMaestro();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DatosGenerales_Load(object sender, EventArgs e)
        {

        }

        private void bttCancelar1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }

        private void bttAtras_Click(object sender, EventArgs e)
        {
            frmAutenticacion primerform = new frmAutenticacion();
            primerform.Show();
            this.Close();
        }

        private void bttSiguiente1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                PrimerNombre = txtPrimerNombre.Text;
                SegundoNombre = txtSegundoNombre.Text;
                PrimerApellido = txtPrimerApellido.Text;
                SegundoApellido = txtSegundoApellido.Text;
                TipoDocumento = CboTipoDocumento.SelectedItem as TipoDocumento;
                NumeroDocumento = txtNoIdentificacion.Text;
                FechaNacimiento = dtFechaNacimiento.Value;
                MunicipioResidencia = cboMunicipioResidencia.SelectedItem as Municipio;
                Departamento = CboDepartamentoResidencia.SelectedItem as Departamento;
                Sexo = cboSexo.SelectedItem as Sexo;
                OrientacionSexual = cboOrientaciónSexual.SelectedItem as Orientacion;
                Sede = cboSede.SelectedItem as Sede;
                Facultad = cboFacultad.SelectedItem as Facultad;




                if (string.IsNullOrWhiteSpace(txtPrimerNombre.Text) || string.IsNullOrWhiteSpace(txtPrimerApellido.Text) || string.IsNullOrWhiteSpace(txtNoIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtDireccionResidencia.Text) || (CboTipoDocumento.SelectedIndex == -1)
                || (CboDepartamentoResidencia.SelectedIndex == -1) || (cboSexo.SelectedIndex == -1) || (cboOrientaciónSexual.SelectedIndex == -1)
                || (cboIdentidadGenero.SelectedIndex == -1) || (cboFacultad.SelectedIndex == -1) || (cboMunicipioResidencia.SelectedIndex == -1))
                {
                    MessageBox.Show("No se puede dejar espacios sin responder");
                    return;
                }
                var datosGenerales = new Entidades.DatosGenerales();
                RutaVioleta.DatosGenerales= datosGenerales;
                datosGenerales.PrimerNombre = PrimerNombre;

                VinculoDetalle tercerform = new VinculoDetalle();
                tercerform.Show();
                this.Hide();

            };


        }

        private bool ValidarDatos()
        {
            throw new NotImplementedException();
        }

        private void CboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblDatosGenerales_Click(object sender, EventArgs e)
        {

        }






        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }



        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }



        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                cboFacultad.Items.Clear();
                if (cboSede.SelectedItem != null)
                {
                    string selectedSede = cboSede.SelectedItem.ToString();
                    if (selectedSede == "Medellín - Área de la Salud")
                    {
                        cboFacultad.Items.Add("Medicina");
                        cboFacultad.Items.Add("Salud Publica");
                        cboFacultad.Items.Add("Odontologia");
                        cboFacultad.Items.Add("Enfermeria");

                    }
                    if (selectedSede == "Seccional Oriente")
                    {
                        cboFacultad.Items.Add("Administración de Empresas");
                        cboFacultad.Items.Add("Ingeniería Ambiental");
                        cboFacultad.Items.Add("Ingeniería de Sistemas");
                        cboFacultad.Items.Add("Contaduría Pública");
                        cboFacultad.Items.Add("Trabajo Social");

                    }
                    if (selectedSede == "Seccional Bajo Cauca")
                    {
                        cboFacultad.Items.Add("Administración de Empresas");
                        cboFacultad.Items.Add("Ingeniería Agropecuaria");
                        cboFacultad.Items.Add("Ingeniería de Sistemas");
                        cboFacultad.Items.Add("Enfermeria");
                        cboFacultad.Items.Add("Trabajo Social");

                    }
                    if (selectedSede == "Seccional Urabá")
                    {
                        cboFacultad.Items.Add("Administración de Empresas");
                        cboFacultad.Items.Add("Ingeniería Agropecuaria");
                        cboFacultad.Items.Add("Ingeniería Ambiental");
                        cboFacultad.Items.Add("Contaduría Pública");
                        cboFacultad.Items.Add("Trabajo Social");

                    }
                    if (selectedSede == "Seccional Magdalena Medio")
                    {
                        cboFacultad.Items.Add("Administración de Empresas");
                        cboFacultad.Items.Add("Ingeniería de Sistemas");
                        cboFacultad.Items.Add("Ingeniería Ambiental");
                        cboFacultad.Items.Add("Contaduría Pública");
                        cboFacultad.Items.Add("Ingenieria Industrial");

                    }


                }

            }
        }

        private void CboDepartamentoResidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                cboMunicipioResidencia.Items.Clear();
                if (CboDepartamentoResidencia.SelectedItem != null)
                {

                }
            }
        }

        private void txtDireccionResidencia_TextChanged(object sender, EventArgs e)
        {

        }



        private void cboOrientaciónSexual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboIdentidadGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            this.dtFechaNacimiento.MaxDate = DateTime.Now;
        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatosGenerales_Load_1(object sender, EventArgs e)
        {
            CboTipoDocumento.DisplayMember = "Nombre";
            CboTipoDocumento.DataSource = servicioMaestro.ObtenerTiposDocumento();

            CboDepartamentoResidencia.DisplayMember = "Nombre";
            CboDepartamentoResidencia.DataSource = servicioMaestro.ObtenerDepartamento();

            cboMunicipioResidencia.DisplayMember = "Nombre";
            cboMunicipioResidencia.DataSource = servicioMaestro.ObtenerMunicipios();

            cboSexo.DisplayMember = "Nombre";
            cboSexo.DataSource = servicioMaestro.ObtenerSexos();

            cboOrientaciónSexual.DisplayMember = "Nombre";
            cboOrientaciónSexual.DataSource = servicioMaestro.ObtenerOrientacionSexual();

            cboIdentidadGenero.DisplayMember = "Nombre";
            cboIdentidadGenero.DataSource = servicioMaestro.ObtenerIdentidadGeneros();

            cboSede.DisplayMember = "Nombre";
            cboSede.DataSource = servicioMaestro.ObtenerSedes();

            cboFacultad.DisplayMember = "Nombre";
            cboFacultad.DataSource = servicioMaestro.ObtenerFacultades();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RutaVioleta
{
    private IServicioRutaVioleta servicioRutaVioleta;
    private IServicioMaestro servicioMaestro;
    private ViolenciaPrejuicios ViolenciaPrejuicio;
    private ViolenciaInstitucional ViolenciaInstitucional;
    private ActivacionInterna ActivacionInterna;
    private RemisionEspecialistas RemisionEspecialistas;
    public partial class TipoViolenciaPrejuicio : Form
    {
        public TipoViolenciaPrejuicio()
        {
            InitializeComponent();
            servicioRutaVioleta = new ServicioRutaVioleta();
            servicioMaestro = new ServicioMaestro();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttAtras3_Click(object sender, EventArgs e)
        {
            TipoViolencia primerform = new TipoViolencia();
            primerform.Show();
            this.Close();
        }

        private void bttCancelar4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }

        private void TipoViolenciaPrejuicio_Load(object sender, EventArgs e)
        {

        }

        

        private void bttGuardar2_Click(object sender, EventArgs e)

        {
            if (ValidarDatos())
            {
                ViolenciaPrejuicio = clbTipoViolenciaPrejuicio.CheckedItems as ViolenciaPrejuicio;
                ViolenciaInstitucional = cblTipoViolenciaInstitucional.CheckedItems as ViolenciaInstitucional;
                ActivacionInterna = clbActivacionInterna.CheckedItems as ActivacionInterna;
                RemisionEspecialistas = clbRemisionEspecialistas.CheckedItems as RemisionEspecialistas;
            }

            if (clbTipoViolenciaPrejuicio.CheckedItems.Count == 0 || cblTipoViolenciaInstitucional.CheckedItems.Count == 0 ||
                clbActivacionInterna.CheckedItems.Count == 0 || clbRemisionEspecialistas.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }
            //Guardar ya todo


            if (clbTipoViolenciaPrejuicio.CheckedItems.Count == 1 || cblTipoViolenciaInstitucional.CheckedItems.Count == 1 ||
                clbActivacionInterna.CheckedItems.Count == 1 || clbRemisionEspecialistas.CheckedItems.Count == 1)

            {
                MessageBox.Show("Sus datos han sido guardados correctamente");
            }
                Application.Exit();
        }
        private bool ValidarDatos()
        {
            bool datosCorrectos = true;
            erpError.SetError(clbTipoViolenciaPrejuicio, null);
            erpError.SetError(cblTipoViolenciaInstitucional, null);
            erpError.SetError(clbActivacionInterna, null);
            erpError.SetError(clbRemisionEspecialistas, null);

            if (clbTipoViolenciaPrejuicio.CheckedItems == null)
            {
                datosCorrectos = false; erpError.SetError(clbTipoViolenciaPrejuicio, "Debe seleccionar el Tipo de Violencia Prejuicio");
            }
            if (cblTipoViolenciaInstitucional.CheckedItems == null)
            {
                datosCorrectos = false; erpError.SetError(cblTipoViolenciaInstitucional, "Debe seleccionar el Tipo de Violencia Institucional");
            }
            if (clbActivacionInterna.CheckedItems == null)
            {
                datosCorrectos = false; erpError.SetError(clbActivacionInterna, "Debe seleccionar la Activacion");
            }
            if (clbRemisionEspecialistas.CheckedItems == null)
            {
                datosCorrectos = false; erpError.SetError(clbRemisionEspecialistas, "Debe seleccionar la Remision");
            }


        }
        private void TipoViolenciaPrejuicio_Load(object sender, EventArgs e)
        {
            clbTipoViolenciaPrejuicio.DisplayMember = "Nombre";
            clbTipoViolenciaPrejuicio.DataSource = servicioMaestro.ObtenerViolenciaPrejuicios();

            cblTipoViolenciaInstitucional.DisplayMember = "Nombre";
            cblTipoViolenciaInstitucional.DataSource = servicioMaestro.ObtenerViolenciaInstitucional();

            clbActivacionInterna.DisplayMember = "Nombre";
            clbActivacionInterna.DataSource = servicioMaestro.ObtenerActivacionInterna();

            clbRemisionEspecialistas.DisplayMember = "Nombre";
            clbRemisionEspecialistas.DataSource = servicioMaestro.ObtenerRemisionEspecialistas();
        }


    }
}

using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestaRutaVioleta
{

    public partial class TipoViolenciaPrejuicio : Form
    {
        private IServicioRutaVioleta servicioRutaVioleta;
        private IServicioMaestro servicioMaestro;

        private ViolenciaPrejuicio ViolenciaPrejuicio;
        private ViolenciaInstitucional ViolenciaInstitucional;
        private ActivacionInterna ActivacionInterna;
        private RemisionEspecialistas RemisionEspecialistas;
        public TipoViolenciaPrejuicio()
        {
            InitializeComponent();
            servicioRutaVioleta = new ServicioRutaVioleta();
            servicioMaestro = new ServicioMaestro();
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





        private void bttGuardar2_Click(object sender, EventArgs e)

        {
            
            
                

            if (clbTipoViolenciaPrejuicio.CheckedItems.Count == 0 || cblTipoViolenciaInstitucional.CheckedItems.Count == 0 ||
                clbActivacionInterna.CheckedItems.Count == 0 || clbRemisionEspecialistas.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }



            
            var violenciasPrejuicio = new List<ViolenciaPrejuicio>();
            var violenciaInstitucional = new List<ViolenciaInstitucional>();
            var activacionInterna= new List<ActivacionInterna>();
            var remisionEspecialistas = new List<RemisionEspecialistas>();

            for (int x = 0; x < clbTipoViolenciaPrejuicio.CheckedItems.Count; x++)
            {
                violenciasPrejuicio.Add(clbTipoViolenciaPrejuicio.CheckedItems[x] as ViolenciaPrejuicio);
            }
            for (int x = 0; x < cblTipoViolenciaInstitucional.CheckedItems.Count; x++)
            {
                violenciaInstitucional.Add(cblTipoViolenciaInstitucional.CheckedItems[x] as ViolenciaInstitucional);
            }
            for (int x = 0; x < clbActivacionInterna.CheckedItems.Count; x++)
            {
                activacionInterna.Add(clbActivacionInterna.CheckedItems[x] as ActivacionInterna);
            }
            for (int x = 0; x < clbRemisionEspecialistas.CheckedItems.Count; x++)
            {
                remisionEspecialistas.Add(clbRemisionEspecialistas.CheckedItems[x] as RemisionEspecialistas);
            }
            DatosGenerales.RutaVioleta.ViolenciaPrejuicio = violenciasPrejuicio.FirstOrDefault();
            DatosGenerales.RutaVioleta.ViolenciaInstitucional = violenciaInstitucional.FirstOrDefault();
            DatosGenerales.RutaVioleta.ActivacionInterna = activacionInterna.FirstOrDefault();
            DatosGenerales.RutaVioleta.RemisionEspecialistas = remisionEspecialistas.FirstOrDefault();
            servicioRutaVioleta.GuardarRutaVioleta(DatosGenerales.RutaVioleta);

            var datos = @"Evaluación almacenada correctamente";

            MessageBox.Show(datos, "Datos", MessageBoxButtons.OK);
            
        }


        
    }
}



   
 
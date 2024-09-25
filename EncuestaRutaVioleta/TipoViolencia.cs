using Entidades;
using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestaRutaVioleta
{
    
    public partial class TipoViolencia : Form
    {
        private IServicioRutaVioleta servicioRutaVioleta;
        private IServicioMaestro servicioMaestro;

        private Entidades.ViolenciaSexual violenciaSexual;
        private Entidades.ViolenciaFisica violenciaFisica;
        private Entidades.ViolenciaEconomica violenciaEconomica;
        public TipoViolencia()
        {
            InitializeComponent();
            servicioRutaVioleta = new ServicioRutaVioleta();
            servicioMaestro = new ServicioMaestro();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblViolenciaEconomica_Click(object sender, EventArgs e)
        {

        }

        private void bttAtras2_Click(object sender, EventArgs e)
        {
            VinculoDetalle primerform = new VinculoDetalle();
            primerform.Show();
            this.Close();
        }

        private void bttSiguiente3_Click(object sender, EventArgs e)
        {
           
            if (clbTipoViolenciaSexual.CheckedItems.Count == 0 || clbTipoViolenciaFisica.CheckedItems.Count == 0 || clbViolenciaEconomica.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }
            
            var violenciaSexual=  new List<Entidades.ViolenciaSexual>();
            var violenciaFisica= new List <Entidades.ViolenciaFisica>();
            var violenciaeconomica = new List<Entidades.ViolenciaEconomica>();
            for (int x = 0; x < clbTipoViolenciaSexual.CheckedItems.Count; x++)
            {
                violenciaSexual.Add(clbTipoViolenciaSexual.CheckedItems[x] as Entidades.ViolenciaSexual);
            }
            for (int x = 0; x < clbTipoViolenciaFisica.CheckedItems.Count; x++)
            {
                violenciaFisica.Add(clbTipoViolenciaFisica.CheckedItems[x] as Entidades.ViolenciaFisica);
            }
            for (int x = 0; x < clbViolenciaEconomica.CheckedItems.Count; x++)
            {
                violenciaeconomica.Add(clbViolenciaEconomica.CheckedItems[x] as Entidades.ViolenciaEconomica);
            }


            DatosGenerales.RutaVioleta.ViolenciaEconomica = violenciaeconomica.FirstOrDefault();
            DatosGenerales.RutaVioleta.ViolenciaFisica = violenciaFisica.FirstOrDefault();
            DatosGenerales.RutaVioleta.ViolenciaSexual = violenciaSexual.FirstOrDefault();

            TipoViolenciaPrejuicio tercerform = new TipoViolenciaPrejuicio();
            tercerform.Show();
            this.Hide();
        }

        private bool ValidarDatos()
        {
            throw new NotImplementedException();
        }

        private void bttCancelar3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }

        private void TipoViolencia_Load(object sender, EventArgs e)
        {
            clbTipoViolenciaSexual.DisplayMember = "Nombre";
            clbTipoViolenciaSexual.DataSource = servicioMaestro.ObtenerViolenciaPrejuicios();

            clbTipoViolenciaFisica.DisplayMember = "Nombre";
            clbTipoViolenciaFisica.DataSource = servicioMaestro.ObtenerViolenciaInstitucional();

            clbViolenciaEconomica.DisplayMember = "Nombre";
            clbViolenciaEconomica.DataSource = servicioMaestro.ObtenerActivacionInterna();

        }   

    }
}

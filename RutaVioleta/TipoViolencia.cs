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
    private ViolenciaSexuales ViolenciaSexual;
    private ViolenciaFisicas ViolenciaFisica;
    private ViolenciaEconomicas ViolenciaEconomica;
    public partial class TipoViolencia : Form
    {
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
            if (ValidarDatos())
            {
                ViolenciaSexual = clbTipoViolenciaSexual.CheckedItems as ViolenciaSexual;
                ViolenciaFisica = clbTipoViolenciaFisica.CheckedItems as ViolenciaFisica;
                ViolenciaEconomica = clbViolenciaEconomica.CheckedItems as ViolenciaEconomica;

            }
            if (clbTipoViolenciaSexual.CheckedItems.Count == 0 || clbTipoViolenciaFisica.CheckedItems.Count == 0 || clbViolenciaEconomica.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }
            var tipoViolencia = new TipoViolencia();

            TipoViolenciaPrejuicio tercerform = new TipoViolenciaPrejuicio();
            tercerform.Show();
            this.Close();
        }
        private bool ValidarDatos()
        {
            bool datosCorrectos = true;
            erpError.SetError(clbTipoViolenciaSexual, null);
            erpError.SetError(clbTipoViolenciaFisica, null);
            erpError.SetError(clbViolenciaEconomica, null);

            if (clbTipoViolenciaSexual.CheckedItems == null)
            {
                datosCorrectos = false; erpError.SetError(clbTipoViolenciaSexual, "Debe seleccionar el Tipo de Violencia Sexual");
            }
            if (clbTipoViolenciaFisica.CheckedItems == null)
            {
                datosCorrectos = false; erpError.SetError(clbTipoViolenciaFisica, "Debe seleccionar el Tipo de Violencia Fisica");
            }
            if (clbViolenciaEconomica.CheckedItems == null)
            {
                datosCorrectos = false; erpError.SetError(clbViolenciaEconomica, "Debe seleccionar el Tipo de Violencia Economica");
            }

        }
        private void TipoViolencia_Load(object sender, EventArgs e)
        {
            clbTipoViolenciaSexual.DisplayMember = "Nombre";
            clbTipoViolenciaSexual.DataSource = servicioMaestro.ObtenerViolenciaSexuales();

            clbTipoViolenciaFisica.DisplayMember = "Nombre";
            clbTipoViolenciaFisica.DataSource = servicioMaestro.ObtenerViolenciaFisicas();

            clbViolenciaEconomica.DisplayMember = "Nombre";
            clbViolenciaEconomica.DataSource = servicioMaestro.ObtenerViolenciaEconomicas();
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

        }

        
    }
}

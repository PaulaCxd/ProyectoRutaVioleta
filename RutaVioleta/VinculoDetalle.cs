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
    public partial class VinculoDetalle : Form
    {
        private IServicioRutaVioleta servicioRutaVioleta;
        private IServicioMaestro servicioMaestro;
        private Vinculo Vinculo;
        private string Cuales;
        private ViolenciaPsicologicas TipoViolenciaPsicologica;
        public VinculoDetalle()
        {
            InitializeComponent();
            servicioRutaVioleta = new ServicioRutaVioleta ();
            servicioMaestro = new ServicioMaestro();
        }

        private void lblPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttSiguiente1_Click(object sender, EventArgs e)
        {    
            if (ValidarDatos())
            {
                Cuales = txtCuales.Text;
                Vinculo = clbVinculoPersonaV.CheckedItems as List<Vinculo>;
                TipoViolenciaPsicologica = clbTipoViolenciaPsicologica.CheckedItems as TipoViolenciaPsicologica;

            }
            if (clbVinculoPersonaV.CheckedItems.Count == 0  || clbTipoViolenciaPsicologica.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }
            var vinculoDetalles = new Entidades.VinculoDetalle();
            TipoViolencia tercerform = new TipoViolencia();
            tercerform.Show();
            this.Close();
        }
        private bool ValidarDatos()
        {
            bool datosCorrectos = true;
            erpError.SetError(clbVinculoPersonaV, null);
            erpError.SetError(clbTipoViolenciaPsicologica, null);
            if (clbVinculoPersonaV.CheckedItems == null)
            {
                datosCorrectos = false; erpError.SetError(clbVinculoPersonaV, "Debe seleccionar el Vinculo");
            }
            if (clbTipoViolenciaPsicologica.CheckedItems == null)
            {
                datosCorrectos = false; erpError.SetError(clbTipoViolenciaPsicologica, "Debe seleccionar el Tipo de ViolenciaPsicologica");
            }
        }
        private void VinculoDetalle_Load(object sender, EventArgs e)
        {
            clbVinculoPersonaV.DisplayMember = "Nombre";
            clbVinculoPersonaV.DataSource = servicioMaestro.ObtenerVinculo();

            clbTipoViolenciaPsicologica.DisplayMember = "Nombre";
            clbTipoViolenciaPsicologica.DataSource = servicioMaestro.ObtenerViolenciaPsicologicas();
        }
            
           


        private void bttAtras1_Click(object sender, EventArgs e)
        {
            DatosGenerales primerform = new DatosGenerales();
            primerform.Show();
            this.Close();
        }

        private void bttCancelar2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar el formulario si el usuario selecciona "Sí"
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

       
    }
}

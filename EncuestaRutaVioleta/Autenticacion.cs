using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace EncuestaRutaVioleta
{
    public partial class frmAutenticacion : Form
    {
        IServicioSeguridad servicioSeguridad = new ServicioSeguridad();
        private IServicioRutaVioleta servicioRutaVioleta;
        private IServicioMaestro servicioMaestro;
        private string Usuario;
        private string Contraseña;
        private object erpError;

        public frmAutenticacion()
        {
            InitializeComponent();
            
        }
        
        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        
        {
           
        }



        private void bttAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Usuario = txtUsuario.Text;
                Contraseña = txtContraseña.Text;
            }


            if (servicioSeguridad.ValidarUsuario(new Entidades.Autenticación() { Contraseña = txtContraseña.Text, Usuario = txtUsuario.Text }))
            {
                var form = new DatosGenerales();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no válidos");
            }


            DatosGenerales secondform = new DatosGenerales();
            secondform.Show();
            this.Hide();
        
        

        }
        private bool ValidarDatos()
        {
            bool datosCorrectos = true;

            erpError.SetError(txtUsuario, null);
            erpError.SetError(txtContraseña, null);

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                datosCorrectos = false;
                erpError.SetError(txtUsuario, "Debe ingresar el usuario");
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                datosCorrectos = false;
                erpError.SetError(txtContraseña, "Debe ingresar el primer nombre");
            }
            return datosCorrectos;

        }
        
     
        private void frmAutenticacion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }
    }
    
}
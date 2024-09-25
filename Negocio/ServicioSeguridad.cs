using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicioSeguridad : IServicioSeguridad
    {
        private IRepositorioSeguridad repositorio;

        public ServicioSeguridad(RepositorioSeguridad repositorio)
        {
            this.repositorio = repositorio;
        }

        public ServicioSeguridad()
        {
            repositorio = new RepositorioSeguridadEF();
        }

        public bool ValidarUsuario(Autenticacion autenticacion)
        {
            var autenticacionActual = repositorio.ObtenerAutenticacion(autenticacion.Usuario);
            if (autenticacionActual != null)
            {
                return autenticacionActual.Contraseña == autenticacion.Contraseña;
            }

            return false;
        }
    }
}


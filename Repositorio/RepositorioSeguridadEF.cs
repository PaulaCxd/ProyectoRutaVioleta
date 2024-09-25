using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioSeguridadEF : RepositorioSeguridad
    {
        private Modelos.DbRutaVioleta dbRutaVioleta;

        public RepositorioSeguridadEF()
        {
            dbRutaVioleta = new Modelos.DbRutaVioleta();
        }

        public Autenticacion ObtenerAutenticacion(string usuario)
        {
            var autenticacionActual = dbRutaVioleta.Autenticacion.FirstOrDefault(u => u.Usuario == usuario);

            if (autenticacionActual != null)
            {
                return new Autenticacion() { Usuario = autenticacionActual.Usuario, Contraseña = autenticacionActual.Contraseña };
            }

            return null;
        }
    }
}

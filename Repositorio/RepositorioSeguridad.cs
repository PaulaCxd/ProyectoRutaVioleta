using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioSeguridad :     IRepositorioSeguridad
    {
        public Autenticacion ObtenerAutenticacion(string usuario)
        {
            return new Autenticacion() { Contraseña = "123", Usuario = usuario };
        }
    }
}

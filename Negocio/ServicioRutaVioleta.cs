using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicioRutaVioleta : IServicioRutaVioleta

    {
        private IRepositorioRutaVioleta repositorio;

        public ServicioRutaVioleta(RepositorioRutaVioleta repositorio)
        {
            this.repositorio = repositorio;
        }

        public ServicioRutaVioleta()
        {
            repositorio = new RepositorioRutaVioletaEF();
        }

        public void GuardarRutaVioleta(RutaVioleta rutaVioleta)
        {
            repositorio.GuardarRutaVioleta(rutaVioleta);
        }
    }
}

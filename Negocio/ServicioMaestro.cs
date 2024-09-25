using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicioMaestro : IServicioMaestro
    {
        private IRepositorioMaestro repositorio;

        public ServicioMaestro(RepositorioMaestro repositorio)
        {
            this.repositorio = repositorio;
        }

        public ServicioMaestro()
        {
            repositorio = new RepositorioMaestroEF();
        }
        public List<Municipio> ObtenerMunicipios()
        => repositorio.ObtenerMunicipio();
        public List<TipoDocumento> ObtenerTiposDocumento()
            => repositorio.ObtenerTiposDocumento();
        public List<Departamento> ObtenerDepartamento()
            => repositorio.ObtenerDepartamentos();
        public List<Orientacion> ObtenerOrientacionSexual()
            => repositorio.ObtenerOrientacionSexual();
        public List<Sexo> ObtenerSexos()
            => repositorio.ObtenerSexos();
        public List<IdentidadGenero> ObtenerIdentidadGeneros()
            => repositorio.ObtenerIdentidadGeneros();
        public List<Sede> ObtenerSedes()
            => repositorio.ObtenerSedes();
        public List<Facultad> ObtenerFacultades()
            => repositorio.ObtenerFacultades();
        public List<Vinculo> ObtenerVinculo()
            => repositorio.ObtenerVinculo();
        public List<ViolenciaPsicologica> ObtenerViolenciaPsicologicas()
            => repositorio.ObtenerViolenciaPsicologicas();
        public List<ViolenciaSexual> ObtenerViolenciaSexuales()
            => repositorio.ObtenerViolenciaSexuales();
        public List<ViolenciaFisica> ObtenerViolenciaFisicas()
            => repositorio.ObtenerViolenciaFisicas();
        public List<ViolenciaEconomica> ObtenerViolenciaEconomicas()
            => repositorio.ObtenerViolenciaEconomicas();
        public List<ViolenciaPrejuicio> ObtenerViolenciaPrejuicios()
            => repositorio.ObtenerViolenciaPrejuicios();
        public List<ViolenciaInstitucional> ObtenerViolenciaInstitucional()
            => repositorio.ObtenerViolenciaInstitucional();
        public List<ActivacionInterna> ObtenerActivacionInterna()
            => repositorio.ObtenerActivacionInterna();
        public List<RemisionEspecialistas> ObtenerRemisionEspecialistas()
            => repositorio.ObtenerRemisionEspecialistas();
    }
}

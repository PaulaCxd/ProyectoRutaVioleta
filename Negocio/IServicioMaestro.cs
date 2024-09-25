using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public interface IServicioMaestro
    {
        List<Municipio> ObtenerMunicipios();
        List<TipoDocumento> ObtenerTiposDocumento();
        List<Departamento> ObtenerDepartamento();
        List<Orientacion> ObtenerOrientacionSexual();
        List<Sexo> ObtenerSexos();
        List<IdentidadGenero> ObtenerIdentidadGeneros();
        List<Sede> ObtenerSedes();
        List<Facultad> ObtenerFacultades();
        List<Vinculo> ObtenerVinculo();
        List<ViolenciaPsicologica> ObtenerViolenciaPsicologicas();
        List<ViolenciaSexual> ObtenerViolenciaSexuales();
        List<ViolenciaFisica> ObtenerViolenciaFisicas();
        List<ViolenciaEconomica> ObtenerViolenciaEconomicas();
        List<ViolenciaPrejuicio> ObtenerViolenciaPrejuicios();
        List<ViolenciaInstitucional> ObtenerViolenciaInstitucional();
        List<ActivacionInterna> ObtenerActivacionInterna();
        List<RemisionEspecialistas> ObtenerRemisionEspecialistas();
      
    }
}

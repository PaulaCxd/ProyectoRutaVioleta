using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Repositorio
{
    public interface IRepositorioMaestro
    {
        List<Municipio> ObtenerMunicipio();
        List<TipoDocumento> ObtenerTiposDocumento();
        List<Departamento> ObtenerDepartamentos();
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

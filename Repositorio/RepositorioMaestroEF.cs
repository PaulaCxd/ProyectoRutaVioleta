using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestroEF : IRepositorioMaestro
    {
        private Modelos.DbRutaVioleta dbRutaVioleta;

        public RepositorioMaestroEF()
        {
            dbRutaVioleta = new Modelos.DbRutaVioleta();
        }

        public List<Municipio> ObtenerMunicipio()
        {
            var municipio = dbRutaVioleta.Municipios
                .Select(c => new Municipio() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return municipio;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = dbRutaVioleta.TipoDocumento
                .Select(c => new TipoDocumento() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return tiposDocumento;
        }
        public List<Departamento> ObtenerDepartamentos()
        {
            var departamentos = dbRutaVioleta.Departamentos
                .Select(c => new Departamento() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return departamentos;
        }
        public List<Sexo> ObtenerSexos()
        {
            var sexos = dbRutaVioleta.Sexos
                .Select(c => new Sexo() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return sexos;
        }
        public List<Orientacion> ObtenerOrientacionSexual()
        {
            var orientacionSexual = dbRutaVioleta.OrientacionSexual
                .Select(c => new Orientacion() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return orientacionSexual;
        }
        public List<IdentidadGenero> ObtenerIdentidadGeneros()
        {
            var identidadGeneros = dbRutaVioleta.IdentidadGeneros
                .Select(c => new IdentidadGenero() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return identidadGeneros;
        }
        public List<Sede> ObtenerSedes()
        {
            var sedes = dbRutaVioleta.Sedes
                .Select(c => new Sede() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return sedes;
        }
        public List<Facultad> ObtenerFacultades()
        {
            var facultades = dbRutaVioleta.Facultades
                .Select(c => new Facultad() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return facultades;
        }
        public List<ViolenciaSexual> ObtenerViolenciaSexuales()
        {
            var violenciaSexuales = dbRutaVioleta.ViolenciaSexuales
                .Select(c => new ViolenciaSexual() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return violenciaSexuales;
        }
        public List<ViolenciaFisica> ObtenerViolenciaFisicas()
        {
            var violenciaFisicas = dbRutaVioleta.ViolenciaFisicas
                .Select(c => new ViolenciaFisica() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return violenciaFisicas;
        }
        public List<ViolenciaEconomica> ObtenerViolenciaEconomicas()
        {
            var violenciaEconomicas = dbRutaVioleta.ViolenciaEconomicas
                .Select(c => new ViolenciaEconomica() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return violenciaEconomicas;
        }
        public List<ViolenciaPrejuicio> ObtenerViolenciaPrejuicios()
        {
            var violenciaPrejuicios = dbRutaVioleta.ViolenciaPrejuicios
                .Select(c => new ViolenciaPrejuicio() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return violenciaPrejuicios;
        }
        public List<ViolenciaInstitucional> ObtenerViolenciaInstitucional()
        {
            var violenciaInstitucional = dbRutaVioleta.ViolenciaInstitucional
                .Select(c => new ViolenciaInstitucional() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return violenciaInstitucional;
        }
        public List<ActivacionInterna> ObtenerActivacionInterna()
        {
            var activacionInterna = dbRutaVioleta.ActivacionInterna
                .Select(c => new ActivacionInterna() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return activacionInterna;
        }
        public List<RemisionEspecialistas> ObtenerRemisionEspecialistas()
        {
            var remisionEspecialistas = dbRutaVioleta.RemisionEspecialistas
                .Select(c => new RemisionEspecialistas() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return remisionEspecialistas;
        }
        public List<Vinculo> ObtenerVinculo()
        {
            var vinculos = dbRutaVioleta.Vinculo
                .Select(c => new Vinculo() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return vinculos;
        }
        public List<ViolenciaPsicologica> ObtenerViolenciaPsicologicas()
        {
            var violenciaPsicologicas = dbRutaVioleta.ViolenciaPsicologicas
                .Select(c => new ViolenciaPsicologica() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return violenciaPsicologicas;
        }
    }
}


using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioRutaVioletaEF : IRepositorioRutaVioleta
    {
        private Modelos.DbRutaVioleta dbRutaVioleta;

        public RepositorioRutaVioletaEF()
        {
            dbRutaVioleta = new Modelos.DbRutaVioleta();
        }

        public void GuardarRutaVioleta(RutaVioleta rutaVioleta)
        {
            var datosGeneralesActual = dbRutaVioleta.DatosGenerales.FirstOrDefault(p => p.IdTipoDocumento == rutaVioleta.DatosGenerales.TipoDocumento.Id &&
           p.NumeroDocumento == rutaVioleta.DatosGenerales.NumeroDocumento);

            int idDatosGenerales = 0;
            if (datosGeneralesActual != null)
            {
                datosGeneralesActual.PrimerNombre = rutaVioleta.DatosGenerales.PrimerNombre;
                datosGeneralesActual.SegundoNombre = rutaVioleta.DatosGenerales.SegundoNombre;
                datosGeneralesActual.PrimerApellido = rutaVioleta.DatosGenerales.PrimerApellido;
                datosGeneralesActual.SegundoApellido = rutaVioleta.DatosGenerales.SegundoApellido;
                datosGeneralesActual.FechaNacimiento = rutaVioleta.DatosGenerales.FechaNacimiento;
                datosGeneralesActual.IdSexo = rutaVioleta.DatosGenerales.Sexo.Id;
                idDatosGenerales = datosGeneralesActual.Id;

                dbRutaVioleta.SaveChanges();
            }
            else
            {
                var datosGeneralesIngresar = new Modelos.DatosGenerales()
                {
                    PrimerNombre = rutaVioleta.DatosGenerales.PrimerNombre,
                    SegundoNombre = rutaVioleta.DatosGenerales.SegundoNombre,
                    PrimerApellido = rutaVioleta.DatosGenerales.PrimerApellido,
                    SegundoApellido = rutaVioleta.DatosGenerales.SegundoApellido,
                    FechaNacimiento = rutaVioleta.DatosGenerales.FechaNacimiento,
                    IdSexo = rutaVioleta.DatosGenerales.Sexo.Id,
                    IdTipoDocumento = rutaVioleta.DatosGenerales.TipoDocumento.Id,
                    NumeroDocumento = rutaVioleta.DatosGenerales.NumeroDocumento,
                };
                dbRutaVioleta.DatosGenerales.Add(datosGeneralesIngresar);
                dbRutaVioleta.SaveChanges();

                idDatosGenerales = datosGeneralesIngresar.Id;
            }
            var rutaVioletaIngresar = new Modelos.RutaVioleta()
            {
                IdDatosGenerales = idDatosGenerales,
                IdActivacionInterna = rutaVioleta.ActivacionInterna.Id,
                IdVinculo = rutaVioleta.Vinculo.Id,
                IdViolenciaEconomica = rutaVioleta.ViolenciaEconomica.Id,
                IdViolenciaFisica = rutaVioleta.ViolenciaFisica.Id,
                IdViolenciaInstitucional= rutaVioleta.ViolenciaInstitucional.Id,
                IdViolenciaPrejuicio = rutaVioleta.ViolenciaPrejuicio.Id,
                IdViolenciaPsicologica = rutaVioleta.ViolenciaPsicologica.Id,
                IdViolenciaSexual = rutaVioleta.ViolenciaSexual.Id
            };

            dbRutaVioleta.RutaVioletas.Add(rutaVioletaIngresar);
            dbRutaVioleta.SaveChanges();
        }
    }
}

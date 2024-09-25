using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("DatosGenerales")]
    public class DatosGenerales
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdTipoDocumento { get; set; }
        public virtual TipoDocumento TiposDocumento { get; set; }
        public int IdSexo { get; set; }
        public virtual Sexo Sexo { get; set; }
        public int IdIdentidadGenero { get; set; }
        public virtual IdentidadGenero IdentidadGenero { get; set; }
        public int IdDepartamento { get; set; }
        public virtual Departamento Departamento { get; set; }
        public int IdMunicipio { get; set; }
        public virtual Municipio Municipio { get; set; }
        public int IdOrientacion { get; set; }
        public virtual Orientacion Orientacion { get; set; }
        public int IdSede { get; set; }
        public virtual Sede Sede { get; set; }
        public int IdFacultad { get; set; }
        public virtual Facultad Facultad { get; set; }
        public int IdRutaVioleta { get; set; }
        public virtual RutaVioleta RutaVioleta { get;set; }

    }
}

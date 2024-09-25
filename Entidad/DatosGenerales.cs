using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatosGenerales
    {
        
        public long Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public Departamento Departamento { get; set; }
        public Municipio Municipio { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public Orientacion OrientacionSexual { get; set; }
        public IdentidadGenero IdentidadGenero{ get; set; }
        public Sede Sede { get; set; }
        public Facultad Facultad { get; set; }
        
    }
}

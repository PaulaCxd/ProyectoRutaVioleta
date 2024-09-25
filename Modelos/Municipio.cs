using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("Municipios")]
    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<DatosGenerales> DatosGenerales { get; set; }
        public int IdDepartamento { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}

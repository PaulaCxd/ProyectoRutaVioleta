using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

    
namespace Modelos
{
    [Table("Departamentos")]
    public class Departamento
    {
        public int Id
        {
            get; set;
        }
        public string Nombre
        {
            get; set;
        }
        public virtual ICollection<Municipio> Municipio { get; set; }
    }
}

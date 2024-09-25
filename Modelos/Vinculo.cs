
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("Vinculo")]
    public class Vinculo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<RutaVioleta> RutaVioleta { get; set; }
    }
}

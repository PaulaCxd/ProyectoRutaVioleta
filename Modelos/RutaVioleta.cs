using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("RutaVioletas")]
    public class RutaVioleta
    {
        public int Id { get; set; }
        public int IdDatosGenerales { get; set; }
        public DatosGenerales DatosGenerales { get; set; }
        public int IdVinculo { get; set; }
        public virtual Vinculo Vinculo { get; set; }
        public int IdViolenciaEconomica { get; set; }
        public virtual ViolenciaEconomica ViolenciaEconomica { get; set; }
        public int IdViolenciaFisica { get; set; }
        public virtual ViolenciaFisica ViolenciaFisica { get; set; }
        public int IdViolenciaInstitucional { get; set; }
        public virtual ViolenciaInstitucional ViolenciaInstitucional { get; set; }
        public int IdViolenciaPrejuicio { get; set; }
        public virtual ViolenciaPrejuicio ViolenciaPrejuicio { get; set; }
        public int IdViolenciaPsicologica { get; set; }
        public virtual ViolenciaPsicologica ViolenciaPsicologica { get; set; }
        public int IdViolenciaSexual { get; set; }
        public virtual ViolenciaSexual ViolenciaSexual { get; set; }
        public int IdActivacionInterna { get; set; }
        public virtual ActivacionInterna ActivacionInterna { get; set; }
        public int IdRemisionEspecialistas { get; set; }
        public virtual RemisionEspecialistas RemisionEspecialistas { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RutaVioleta
    {
        public DatosGenerales DatosGenerales { get; set; }
        public ActivacionInterna ActivacionInterna { get; set; }
        public Vinculo Vinculo { get; set; }
        public  ViolenciaEconomica ViolenciaEconomica { get; set; }
        public ViolenciaFisica ViolenciaFisica { get; set; }
        public ViolenciaInstitucional ViolenciaInstitucional { get; set; }
        public ViolenciaPrejuicio ViolenciaPrejuicio { get; set; } 
        public ViolenciaPsicologica ViolenciaPsicologica { get; set; }
        public ViolenciaSexual ViolenciaSexual { get; set; }
        public RemisionEspecialistas RemisionEspecialistas { get; set; }

    }
}


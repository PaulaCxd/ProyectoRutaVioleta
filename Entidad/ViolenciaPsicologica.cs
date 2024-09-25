using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ViolenciaPsicologica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static implicit operator ViolenciaPsicologica(List<ViolenciaPsicologica> v)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vinculo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static implicit operator Vinculo(List<Vinculo> v)
        {
            throw new NotImplementedException();
        }
    }
}

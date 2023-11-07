using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class Motodecorrida
    {
        public float espessuraroda { get; set; }
        public string ToString()
        {
            string msgDoPai = base.ToString();
            return $"{msgDoPai} {espessuraroda}";

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Motodepasseio
    {
        public string Carenagem { get; set; }
        public string ToString()
        {
            string msgDoPai = base.ToString();
            return $"{msgDoPai} {Carenagem} ";
        }
    }
}

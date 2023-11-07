using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Carro : Veiculo
    {
        public string Modelo { get; set; }

        public void ronco()
        {
            Console.WriteLine("Ronco do carro");
        }
    }
}

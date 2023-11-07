using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class Moto : Veiculo
    {
        public string Modelo { get; set; }
        public int Peso { get; set; }

        public void motor()
        {
            Console.WriteLine("VRUM VRUM");
        }
        public string ToString()
        {
            string msgDoPai = base.ToString();
            return $"{msgDoPai} {Modelo} {Peso}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    class Car
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public string ToString()
        {
            return $"id:{Id} nome:{Placa} marca: {Marca} modelo:{Modelo} cor:{Cor}";
        }
    }
}

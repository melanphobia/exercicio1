using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Categoria
    {
        public string id { get; set; }
        public string pedido { get; set; }
        public string codigo { get; set; }
        public Categoria(string id, string pedido, string codigo)
        {
            id = id;
            pedido = pedido;
            codigo = codigo;
        }
        public string ToString()
        {
            return $"{id} {pedido} {codigo}";
        }
    }
}

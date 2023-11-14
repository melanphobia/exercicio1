using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_POO
{
    class CrudProduto
    {
        public void salvar(Produto prod)
        {
            Console.WriteLine("Salvando. . . . " + prod.Name);
        }

        public void alterar(Produto prod)
        {
            Console.WriteLine("alterando. . . . " + prod.Name);
        }
        
        public void consultar(Produto prod)
        {
            Console.WriteLine("consultando. . . . " + prod.Name);
        }
    }
}

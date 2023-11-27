using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud_3.NovaPasta
{
    class Categoria
    {
        public int Id { get; set; }
        public string Categorias { get; set; }


        public Categoria() { }
        public Categoria(string categorias)
        {
            Categorias = categorias;
        }
        public string ToString()
        {
            return $"{Id} || {Categorias}";
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_POO
{
    class Produto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Preco { get; set; }

        public Produto() { }

        public Produto(int id, string name, decimal preco)
        {
            this.Id = id;
            this.Name = name;
            this.Preco = preco;
        }

        public string ToString()
        {
            return $"{Id} {Name} R${Preco}";
        }
    }
}
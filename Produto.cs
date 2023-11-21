using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_crud
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }

        public Produto() { }
        public Produto(int id, string descricao, string preco)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
        }
    }
}

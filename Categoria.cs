using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_crud
{
    class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public string Descricao { get; set; }


        public Categoria() { }
        public Categoria(int id, string nome,string preco,string descricao)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
        }
        public string ToString()
        {
            return $"{Id} || {Nome} || {Preco} || {Descricao}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Produtos
    {
        public string id { get; set; }
        public string nome { get; set; } = string.Empty;
        public string descricao { get; set; } = string.Empty;
        public decimal? total { get; set; }
        public string categoria { get; set; } = string.Empty;

        public Produtos(string id, string nome, string descricao, decimal? total, string categoria)
        {
            id = id;
            nome = nome;
            descricao = descricao;
            total = total;
            categoria = categoria;
        }
        public string ToString()
        {
            return $"{id} {nome} {descricao} {total} {categoria}";
        }
    }
}

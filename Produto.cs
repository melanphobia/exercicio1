﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_POO_2
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto() { }
        public Produto(int id, string descricao, double preco)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public string ToString()
        {
            return $"{Id} {Descricao} {Preco}";
        }

    }
}
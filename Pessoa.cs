using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agregacaodesafio
{
    class Pessoa
    {
        public int Idade { get; set; }
        public string Endereço { get; set; }
        public int Cpf { get; set; }

        public Pessoa()
        {
        }
        public Pessoa(int idade, string endereço, int cpf)
        {
            Idade = idade;
            Endereço = endereço;
            Cpf = cpf;
        }
        public string ToString()
        {
            return $"{Idade} {Endereço} {Cpf}";
        }
    }
}
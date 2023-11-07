using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class Cliente : Pessoa
    {
        public string Cpf { get; set; }

        public string ToString()
        {
            return $"{Id} {Nome} {Cpf}";
        }
    }
}
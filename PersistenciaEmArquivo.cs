using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_POO_2
{
    public class PersistenciaEmArquivo : IPersistenciaDaFatura
    {
        public void salvar(Fatura fatura)
        {
            Console.WriteLine("Salvando em arquivo");
        }
    }
}
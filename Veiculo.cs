﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class Veiculo
    {
        public string Marca { get; set; }
        public void ronco()
        {
            Console.WriteLine("Ronco do veiculo");
        }
    }
}
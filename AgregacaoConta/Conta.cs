using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agregacao
{
    public class Conta
    {
        public int Numero { get; set; }
        //agregação
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }
    }
}
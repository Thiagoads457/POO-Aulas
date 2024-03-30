using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agregacao
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public Endereco Ender { get; set; }
        public Cliente(string nome, string rg, string cpf)
        {
            Nome = nome;
            RG = rg;
            CPF = cpf;
            
        }
    }
}
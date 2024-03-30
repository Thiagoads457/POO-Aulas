using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private int codigo; // atributo
        private string? nome;
        private double salario;




        public int Codigo // propriedade
        {
            get { return codigo; }
            
            set { 
                if (value > 0)
                {
                    codigo = value;
                }
                else          
                    {
                        Console.WriteLine("Matricula inválida");
                    }
                    
               }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

    }
}
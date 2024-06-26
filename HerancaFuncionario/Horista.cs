using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Horista : Funcionario
    {
        private int qntHorasTrabalhadas;

        public Horista(): base()
        {
        }

        public void Mostrar()
        {
        base.Mostrar();
        Console.WriteLine("Quantidade de horas Trabalhadas: " + QntHorasTrabalhadas);
        
        }

        public Horista(int codigo, string nome, double salario, int qntHorasTrabalhadas) : base(codigo, nome, salario)
        {
            QntHorasTrabalhadas = qntHorasTrabalhadas;
        }
        public int QntHorasTrabalhadas{
            get{return qntHorasTrabalhadas;}
            set{qntHorasTrabalhadas = value;}
        }

    }
    

}
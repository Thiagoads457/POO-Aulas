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
        Console.WriteLine("Quantidade de horas Trabalhadas: " + qntHorasTrabalhadas);
        
        }

        public Horista(int codigo, string nome, double salario, int qntHorasTrabalhadas) : base(int codigo, string nome, double salario)
        {
            QntHorasTrabalhadas = qntHorasTrabalhadas;
        }
        public int QntHorasTrabalhadas{
            get{return qntHorasTrabalhadas;}
            set{qntHorasTrabalhadas = value;}
        }

    }
    

}
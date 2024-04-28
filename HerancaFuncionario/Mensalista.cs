using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Mensalista : Funcionario
    {
         private int qntHorasSemana;

        public Mensalista(): base()
        {
        }

        public void Mostrar()
        {
        base.Mostrar();
        Console.WriteLine("Quantidade de horas Semanais: " + qntHorasSemana);
        
        }

        public Horista(int codigo, string nome, double salario, int qntHorasSemana) : base(int codigo, string nome, double salario)
        {
            QntHorasSemana = qntHorasSemana;
        }
        public int QntHorasSemana{
            get{return qntHorasSemana;}
            set{qntHorasSemana = value;}
        }
    }
}
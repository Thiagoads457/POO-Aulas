using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
        }
        public abstract double CalcularSalario();

        public override double CalcularSalario(int diasUteis );//assinatura de metodo sabemos o que o metodo faz pelo nome dele, sabemos se precisa de valor externo para atender o desenvolvimento da logica (parametro(s)) e se ocorrerá saida de valor. (retur)
    }
}
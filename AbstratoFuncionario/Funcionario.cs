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
        public List<Dependente> VetD { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            VetD = new List<Dependente>();
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("\nCódigo: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);

            if (this.TotalDependentes() > 0)
            {
                Console.WriteLine("DEPENDENTES:");
                this.ListarDependentes();
            }
        }

        public abstract double CalcularSalario(int diasUteis);
        //assinatura de método sabemos o que o método faz pelo nome dele, sabemos se precisa de valor externo para a atender o desenvolvimento da lógica (parâmetro) e se ocorrerá saída de valor (return)

        public int TotalDependentes()
        {
            return VetD.Count;
        }

        public void AdicionarDependente(Dependente d)
        {
            VetD.Add(d);
        }

        public bool RemoverDependente(int codigo)
        {
            for (int i = 0; i < VetD.Count; i++)
            {
                if (VetD[i].Codigo == codigo)
                {
                    VetD.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public void ListarDependentes()
        {
            foreach (Dependente d in VetD)
                Console.WriteLine($"\tNome: {d.Nome}\tIdade: {d.Idade}");
        }
    }
}
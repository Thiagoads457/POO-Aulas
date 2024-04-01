using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }//atributo
        public string Nome { get; set; }

        public Vendedor(string nome)
        {
            Nome = nome;
        }

        public void CalcularComissao(double preco)//metodo
        {
            Comissao = 0.02 * preco;
        }

        public void MostrarAtributosVedendor()//metodo
        {
            Console.WriteLine("Comissão do Vendedor " + Comissao);
        }
    }
}
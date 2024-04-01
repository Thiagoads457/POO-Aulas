using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }//atributo
        public void CalcularComissao(double precoProduto)//metodo
        {
            Comissao = 0.02 * precoProduto;
        }

        public void MostrarAtributosVedendor()//metodo
        {
            Console.WriteLine("Comissão do Vendedor " + Comissao);
        }
    }
}
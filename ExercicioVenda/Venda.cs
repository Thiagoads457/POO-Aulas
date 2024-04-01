using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVenda
{
    public class Venda
    {
        public Vendedor Vend { get; set; }
        public Comprador Comp { get; set; }
        public List<Produto> Vetprod { get; set; }

        

        public void MostrarAtributos()
        {
            Console.WriteLine("Vendendor: " + Vend + "Comprador: " + Comp + "Produto: " + Vetprod);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVenda
{ 
    public class Produto
    {
        private static int codigoInicial = 500;
        //atributos
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        
        public Produto() //construtor
        {
            Codigo = codigoInicial++;
        }
        public void MostrarAtributosProdutos()
        {
            Console.WriteLine("Código do Produto " + Codigo);
            Console.WriteLine("Nome do Produto " + Nome);
            Console.WriteLine("Preço do Produto " + Preco);
        }
    }


}
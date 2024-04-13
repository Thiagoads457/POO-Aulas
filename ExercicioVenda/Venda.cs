using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVenda
{
   public class Venda
    {
        private Comprador comprador;
        private Vendedor vendedor;
        private List<Produto> vetProd;

        public Venda(Comprador comprador, Vendedor vendedor)
        {
            this.comprador = comprador;
            this.vendedor = vendedor;
            this.vetProd = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            

            vetProd.Add(produto);
        }

        public void FinalizarVenda()
        {
            double precoTotal = 0;

            foreach (Produto p in vetProd)
            {
                precoTotal += p.Preco;
            }

            Console.WriteLine($"Preço total: R${precoTotal:c}");

           

            comprador.Verba -= precoTotal;
            vendedor.CalcularComissao(precoTotal);
            vendedor.MostrarAtributo();
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("\nProdutos selecionados:");
            foreach (Produto produto in vetProd)
            {
                produto.MostrarAtributos();
            }
        }
    }  
}


        

       

    

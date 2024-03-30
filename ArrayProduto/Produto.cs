using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        public int codigo;
        public string? nome;
        public double preco;
        public int quantidade;

        public void MostrarAtributos()
        {
            Console.WriteLine($"\nCódigo: {codigo} \nNome: {nome} \nPreço: {preco:c}");
        }

        public void AumentarPrecoPorcetagem (double porcentagem)
        {
            preco = preco + (preco * porcentagem / 100);
        }

        public double ValorTotalEmEstoque()
        {
            return  preco * quantidade;
            
        }
       

        public void RemoverProduto (int remover)
        {
            quantidade -= remover;
        }
    }   

}
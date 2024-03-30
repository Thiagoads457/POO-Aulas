using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProdutos
{
    public class Produtos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public static int Contador { get; set; }

        public Produtos() // Construtor padrão
        {
            Contador++;
        }
        public Produtos(int codigo)
        {
            Codigo = codigo;
            Contador++;
        }
        public Produtos(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Contador++;
        }
        public Produtos(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Contador++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("\nCódigo: " + Codigo + "\tNome: " + Nome + "\tPreco: " + Preco);
        }


    }
}
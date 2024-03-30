using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    //declaração dos atributos
    public class Produto
    {
        public int codigo;
        public string? nome;
        public double preco;

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo} \nNome: {nome} \nPreço: {preco:c}");
        }

        public void AumentarPrecoPorcetagem (double porcentagem)
        {
            preco = preco + (preco * porcentagem / 100);
        }

      

        
    }
}

//métodos
        //crie uma função para apresentar os atributos
        //crie uma função para calcular o aumento do preço de uma porcentagem via parametro.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private double Saldo { get; set; }

        public Poupanca(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:c} realizado com sucesso.");
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:c} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void GerarRendimento(double taxa)
        {
            Saldo *= 1 + (taxa / 100);
            Console.WriteLine($"Rendimento aplicado. Novo saldo: R$ {Saldo:c}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;

        public int Numero//propriedade do encapsulamento
        {
            set{
                this.numero = value; // numeros minusculo é "atributo"
            }
            get{
                return this.numero;
            }
        }
         
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
         
        
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        
        
        

        /*public void SetNumero(int numeroConta) //Set - alterar
        {
            numero = numeroConta;
        }

        public int GetNumero() // Get - Buscar numero
        {
            return numero;
        }*/
        
    }    
    
}
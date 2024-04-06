using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVenda
{
    public class Comprador
    {
        public double Verba { get; set; }

        public Comprador(string nome, double verba)
        {
            Verba = verba
        }
       
        public void MostrarAtributosComprador()
        {
            Console.WriteLine("Verba do Comprador: " + Verba);
        }
        
    }


}
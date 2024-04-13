using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVenda
{
    public class Comprador
    {
        private double verba;

        public double Verba
        {
            get { return verba; }
            set{
                verba = value;
                
            }
        }

        public Comprador(double verba)
        {
            this.verba = verba;
        }

        public void MostrarAtributo()
        {
            Console.WriteLine($"Verba do comprador: R${verba:c}");
        }
    }


}
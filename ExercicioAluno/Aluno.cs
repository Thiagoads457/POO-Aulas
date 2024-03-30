using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAluno
{
    public class Aluno
    
    {
        public string Nome { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Media; // média está fora do private
        public static long Matricula;

        static Aluno()
        {
            Matricula = 1570482223000;
        }
        public Aluno(string nome, double p1, double p2)
        {
            Nome = nome;
            P1 = p1;
            P2 = p2;
            Media = (p1 + p2)/2; 
            Matricula++;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("\nAluno: " + Nome + "\tMatrícula: " + Matricula +"\nP1: " + P1 + "\tP2: " + P2 + "\nMédia: "+ Media);
        }


    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioVenda
{
    public class Vendedor
    {
        private const double comissao = 2;
        private double comissaoRecebida;

        public void MostrarAtributo()
        {
            Console.WriteLine($"Comissão do vendedor: R${comissaoRecebida:c}");
        }

        public void CalcularComissao(double precoTotal)
        {
            comissaoRecebida = precoTotal * (comissao / 100);
        }
    }
}

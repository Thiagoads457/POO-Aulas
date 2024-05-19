using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class GerenciadorBonificacao
    {
          protected double totalBonificacao;
       
        //propriedade para acesso ao atributo;
        public double TotalBonificacao
        {
            get { return totalBonificacao; }
            set { totalBonificacao = value; }
        } 

        //construtor:

        public GerenciadorBonificacao(double totalBonificacao)
        {
            TotalBonificacao = totalBonificacao;
        }

        //polimorfismo estático com sobrecarga de métodos.
        public void TotalizarBonificacao(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.CalcularBonificacao(); 
        }

        public void TotalizarBonificacao(Diretor diretor)
        {
            this.TotalBonificacao += diretor.CalcularBonificacao(); 
        }
        public void TotalizarBonificacao(Gerente gerente)
        {
            this.TotalBonificacao += gerente.CalcularBonificacao(); 
         
        }
        public void TotalizarBonificacao(Secretario secretario)
        {
            this.TotalBonificacao += secretario.CalcularBonificacao(); 
        }
    }
}
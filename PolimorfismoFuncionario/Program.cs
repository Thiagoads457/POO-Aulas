// Método Main()
using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Ana", 1000);
GerenciadorBonificacao g = new GerenciadorBonificacao(0.0);
g.TotalizarBonificacao(f);
Console.WriteLine("Bonificação do funcionário: " + g.TotalBonificacao);

Secretario s = new Secretario(2, "Bel", 1000);
GerenciadorBonificacao g1 = new GerenciadorBonificacao(1.0);
g1.TotalizarBonificacao(s);
Console.WriteLine("Bonificação do secretario: " + g1.TotalBonificacao);

Gerente gr = new Gerente(3,"Bia",1000);
GerenciadorBonificacao g2 = new GerenciadorBonificacao(0.0);
g2.TotalizarBonificacao(gr);
Console.WriteLine("Bonificação do gerente: " + g2.TotalBonificacao);

Diretor d = new Diretor(4, "Leo", 1000);
GerenciadorBonificacao g3 = new GerenciadorBonificacao(0.0);
g3.TotalizarBonificacao(d);
Console.WriteLine("Bonificação do diretor: " + g3.TotalBonificacao);



using EncapsulamentoFuncionario;

Funcionario c1 = new Funcionario();
c1.Codigo = 10; // Set
Console.WriteLine("Código:" + c1.Codigo);//Get

c1.Nome = "Thiago"; // set (pois tem o sinal de atribuição =)
c1.Salario = 1050;
Console.WriteLine("Nome:" + c1.Nome);
Console.WriteLine($"Salario: {c1.Salario:c}");

Funcionario c2 = new Funcionario();
c2.Codigo = 20;
c2.Nome = "joão";
c2.Salario = 2000;
Console.WriteLine("Nome:" + c2.Nome);
Console.WriteLine($"Salario: {c2.Salario:c}");
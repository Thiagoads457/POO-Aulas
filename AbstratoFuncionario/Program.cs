using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);

Comissionado c1 = new Comissionado(3, "Teo", 1000, 20);
Comissionado c2 = new Comissionado(4, "Tais", 1000, 30);

Dependente dp1 = new Dependente(1, "João", 12);
Dependente dp2 = new Dependente(2, "Lucas", 13);
Dependente dp3 = new Dependente(3, "Diana", 14);
Dependente dp4 = new Dependente(4, "Tobias", 20);
Dependente dp5 = new Dependente(5, "Pedro", 7);
Dependente dp6 = new Dependente(6, "Ricardo", 8);

a2.AdicionarDependente(dp1);
c1.AdicionarDependente(dp2);
c1.AdicionarDependente(dp3);
c2.AdicionarDependente(dp4);
c2.AdicionarDependente(dp5);
c2.AdicionarDependente(dp6);

Departamento d1 = new Departamento(10, "TI");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionarios();
Console.WriteLine($"\nTotal {d1.CalcularFolha(30):c}");

Departamento d2 = new Departamento(11, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.ListarFuncionarios();
Console.WriteLine($"\nTotal {d2.CalcularFolha(30):c}");
//d2.Demitir(4);
//d2.ListarFuncionarios();

a2.RemoverDependente(1);
c2.RemoverDependente(6);
Console.WriteLine("\nAPÓS A REMOÇÃO DOS DEPENDENTES...");
d1.ListarFuncionarios();
d2.ListarFuncionarios();
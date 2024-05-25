using InterfaceAutenticado;

Cliente c = new Cliente();
c.Senha = 100;

IAutenticavel itc = c;
Console.WriteLine("Autenticou? " + itc.Autenticar(100));

Diretor d = new Diretor();
d.Senha = 200;

IAutenticavel itd =d;
Console.WriteLine("Autenticou? " + itd.Autenticar(200));

Gerente g = new Gerente();
g.Senha = 300;

IAutenticavel itg = g;
Console.WriteLine("Autenticou? " + itg.Autenticar(301));



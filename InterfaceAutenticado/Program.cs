using InterfaceAutenticado;

Cliente c = new Cliente();
c.Senha = 100;

IAutenticavel it = c;
Console.WriteLine("Autenticou? " + it.Autenticar(100));

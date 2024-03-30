// função Main()

using ClasseConta; //chamando a classeConta 

Conta objetoConta; //declarar variável
objetoConta = new Conta(); // instacia de objeto
objetoConta.numero = 1;
objetoConta.titular = "Paul";
objetoConta.saldo = 100.57;
objetoConta.MostrarAtributos();
objetoConta.Sacar(10);
objetoConta.MostrarAtributos();

//outra forma de instanciação - mais usada

Conta objetoConta2 = new Conta();
Console.Write("Digite o número: ");
objetoConta2.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o Titular: ");
objetoConta2.titular = Console.ReadLine();
Console.Write("Digite o Saldo: ");
objetoConta2.saldo = Convert.ToDouble(Console.ReadLine());
objetoConta2.MostrarAtributos();
objetoConta2.Depositar(100);
objetoConta2.MostrarAtributos();


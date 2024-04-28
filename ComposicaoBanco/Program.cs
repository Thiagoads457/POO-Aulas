using ComposicaoBanco;

Banco banco = new Banco(10, 10);

Console.WriteLine("Abertura de contas");
banco.AbrirContaCorrente(1200, 600);
banco.AbrirContaCorrente(600, 300);
banco.AbrirContaCorrente(100, 50);
banco.AbrirPoupanca(100);

Console.WriteLine("\nConta corrente");

banco.contasCorrente[0].Depositar(600);
banco.contasCorrente[0].Sacar(50);
banco.contasCorrente[0].GerarExtrato();

Console.WriteLine("\nConta corrente + cheque especial");

banco.contasCorrente[1].Depositar(200);
banco.contasCorrente[1].Sacar(600);
banco.contasCorrente[1].GerarExtrato();

Console.WriteLine("\nConta corrente sem saldo suficiente");

banco.contasCorrente[2].Depositar(100);
banco.contasCorrente[2].Sacar(250);
banco.contasCorrente[2].GerarExtrato();

Console.WriteLine("\nConta poupança");

banco.poupancas[0].Depositar(200);
banco.poupancas[0].Sacar(70);
banco.poupancas[0].GerarRendimento(20);

Console.WriteLine("\nFalência");
banco.DecretarFalencia();
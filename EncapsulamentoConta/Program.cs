using EncapsulamentoConta;

Conta c1 = new Conta();
//c1.SetNumero(1000);
//Console.WriteLine("Número:" + c1.GetNumero());
// Usando o padrão C# para o encapsulamento

c1.Numero = 1000; // Set
Console.WriteLine("Número:" + c1.Numero);//Get

c1.Titular = "Fatec"; // set (pois tem o sinal de atribuição =)
c1.Saldo = 1050;
Console.WriteLine("Titular:" + c1.Titular);
Console.WriteLine("Saldo:" + c1.Saldo);
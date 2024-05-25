//Método Main

using InterfaceTributavel;

ContaCorrente cc = new ContaCorrente(10000);

//Console.WriteLine($"Tributo a pagar da conta corrente: {itc.CalculaTributos():c}" );


SeguroDeVida sg = new SeguroDeVida();

//Console.WriteLine($"O valor do seguro de vida é de: {it.CalculaTributos():c}" );

TotalizadorDeTributos t = new TotalizadorDeTributos();
t.Adicionar(cc);
t.Adicionar(sg);
Console.WriteLine($"O valor total é de: {t.Total:c}" );

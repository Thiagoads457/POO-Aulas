using ClasseProduto;
// isntacia de objeto de produto = tipo
Produto objetoProduto = new Produto();

objetoProduto.codigo = 1;
objetoProduto.nome = "Moto";
objetoProduto.preco = 100.00;
objetoProduto.MostrarAtributos();
objetoProduto.AumentarPrecoPorcetagem(10);
objetoProduto.MostrarAtributos();


Produto objetoProduto2 = new Produto();
Console.Write("Digite o código do Produto: ");
objetoProduto2.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o nome: ");
objetoProduto2.nome = Console.ReadLine();
Console.Write("Digite o Preço do Produto: ");
objetoProduto2.preco = Convert.ToDouble(Console.ReadLine());
objetoProduto2.MostrarAtributos();
Console.WriteLine("Informe a Porcentagem de aumento: ");
double percentual = Convert.ToDouble(Console.ReadLine());
objetoProduto2.AumentarPrecoPorcetagem(percentual);
objetoProduto2.MostrarAtributos();





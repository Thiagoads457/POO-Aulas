using ArrayProduto;

Produto[] vetP = new Produto[2];

for(int i = 0; i <vetP.Length; i++)
{
    vetP[i] = new Produto();
    Console.Write("\nDigite o Código do Produto: ");
    vetP[i].codigo = Convert.ToInt32(Console.ReadLine());
    Console.Write("Digite o Nome do Produto: ");
    vetP[i].nome = Console.ReadLine();
    Console.Write("Digite o Preço do Produto: ");
    vetP[i].preco = Convert.ToInt32(Console.ReadLine());
    Console.Write ("Digite a quantidade: ");
    vetP[i].quantidade = Convert.ToInt32(Console.ReadLine());

}
foreach (Produto p in vetP)
p.MostrarAtributos();


Console.Write("Informe a Porcentagem de aumento: ");
double percentual = Convert.ToDouble(Console.ReadLine());




foreach (Produto p in vetP)
{
    p.AumentarPrecoPorcetagem(percentual);
    p.MostrarAtributos();
    
}





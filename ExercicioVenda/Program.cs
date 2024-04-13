using ExercicioVenda;

Produto produto1 = new Produto("Produto 1", 80);
Produto produto2 = new Produto("Produto 2", 110);
Produto produto3 = new Produto("Produto 3", 50);

Comprador comprador = new Comprador(600);
Vendedor vendedor = new Vendedor();

Venda venda1 = new Venda(comprador, vendedor);

Console.WriteLine("\n=-=-=-=-= Venda 1 =-=-=-=-=");
venda1.AdicionarProduto(produto1);
venda1.AdicionarProduto(produto2);
venda1.MostrarAtributos();
venda1.FinalizarVenda();

comprador.MostrarAtributo();

Venda venda2 = new Venda(comprador, vendedor);

Console.WriteLine("\n=-=-=-=-= Venda 2 =-=-=-=-=");
venda2.AdicionarProduto(produto1);
venda2.AdicionarProduto(produto2);
venda2.AdicionarProduto(produto3);
venda2.MostrarAtributos();
venda2.FinalizarVenda();

comprador.MostrarAtributo();






using ConstrutorProdutos;

Produtos c1 = new Produtos(); // construtor padrão
c1.MostrarAtributos();

Produtos c2 = new Produtos(500);
c2.MostrarAtributos();

Produtos c3 = new Produtos(500,"Impressora");
c3.MostrarAtributos();

Produtos c4 = new Produtos(500,"Impressora",1500);
c4.MostrarAtributos();

Console.WriteLine("Total de Instancias: " + Produtos.Contador);

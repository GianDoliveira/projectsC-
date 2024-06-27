using System.Globalization;
using produto;

#pragma warning disable CS8601
#pragma warning disable CS8604
#pragma warning disable CS8600

Produto p = new Produto("Tv", 2300.00, 10);

p.Nome = "TV 4K";

System.Console.WriteLine(p.Nome);
System.Console.WriteLine(p.Preco);
System.Console.WriteLine(p.Quantidade);

// System.Console.WriteLine("Entre os dados do produto:");

// Console.Write("Nome: ");

// string nome = Console.ReadLine();
// Console.Write("Preço: ");
// double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// Console.Write("Quantidade: ");
// int quantidade = int.Parse(Console.ReadLine());

// Produto p = new Produto(nome, preco, quantidade);

// System.Console.WriteLine("Dados do produto: " + p);

// System.Console.WriteLine("");

// System.Console.Write("Digite o número de produtos a ser adicionado:");
// int qte = int.Parse(Console.ReadLine());
// p.AdicionarProdutos(qte);
// System.Console.WriteLine("Dados atualizados: " + p);

// System.Console.WriteLine("");

// System.Console.Write("Digite o número de produtos a ser removido:");
// qte = int.Parse(Console.ReadLine());
// p.RemoverProdutos(qte);
// System.Console.WriteLine("Dados atualizados: " + p);

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8601

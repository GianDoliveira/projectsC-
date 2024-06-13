using System.Globalization;
using produto;

#pragma warning disable CS8601
#pragma warning disable CS8604 

Produto p = new Produto();

System.Console.WriteLine("Entre os dados do produto:");

Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
p.Quantidade = int.Parse(Console.ReadLine());

System.Console.WriteLine("Dados do produto: " + p);

#pragma warning restore CS8604
#pragma warning restore CS8601
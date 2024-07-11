using System.Globalization;
using arrays;

#pragma warning disable CS8604
#pragma warning disable CS8600
#pragma warning disable CS8601

Product[] vect = new Product[10];

Console.Write("Quantos quartos serão alugados ?");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Aluguel #{i}:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    vect[quarto] = new Product(nome, email);
}

Console.WriteLine();
Console.WriteLine("Quartos ocupados:");
for (int i = 0; i < 10; i++)
{
    if (vect[i] != null)
    {
        Console.WriteLine(i + ": " + vect[i]);
    }
}
#pragma warning restore CS8601
#pragma warning restore CS8600
#pragma warning restore CS8604

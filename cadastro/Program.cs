using System.Runtime.InteropServices;
using cadastro;
#pragma warning disable CS8600
#pragma warning disable CS8604
#pragma warning disable CS8601

Registro x = new Registro();

System.Console.Write("Nome Completo:");
x.Nome = Console.ReadLine();
System.Console.Write("Digite seu CPF:");
x.Cpf = Console.ReadLine();
System.Console.Write("Data de Nascimento:");
x.Nascimento = DateTime.Parse(Console.ReadLine());
System.Console.Write("Endereço:");
x.Rua = Console.ReadLine();
x.Bairro = Console.ReadLine();
x.Cidade = Console.ReadLine();
System.Console.WriteLine(" ");

System.Console.WriteLine("Dados pessoais:");
System.Console.WriteLine(x);

#pragma warning restore CS8601
#pragma warning restore CS8604
#pragma warning restore CS8600

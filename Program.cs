using _1.TesteGetSet.Models;

Console.WriteLine("Digite seu nome aqui: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade aqui:");
int idade = int.Parse(Console.ReadLine());

Pessoa pessoa = new Pessoa(nome, idade);

Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");

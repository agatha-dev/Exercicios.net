// digite um número e encontre o sucessor dele

int x, sucessor = 0;

Console.WriteLine("Digite um número!");

x = int.Parse(Console.ReadLine());

sucessor = x;
sucessor = sucessor + 1;
Console.WriteLine("O sucessor de  " + x + " é  " + sucessor);
Console.ReadKey();

//  Desenvolva um algoritmo que solicite a entrada de um número e calcule se o número é par ou impar.

int umNumero = x;
Console.WriteLine("Digite um número!");
umNumero = Convert.ToInt32(Console.ReadLine()); //Lê e converte para int o número informado pelo usuário

if(umNumero % 2 == 0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Impar");
}
Console.ReadKey();


// Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.

String Nome;
Console.WriteLine("Escreva seu Nome!");
Nome = Console.ReadLine();

Console.WriteLine("Meu nome é: " + Nome, "");




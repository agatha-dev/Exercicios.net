//digite um número e encontre o sucessor dele

int x, sucessor = 0;

Console.WriteLine("Digite um número!");

x = int.Parse(Console.ReadLine());

sucessor = x;
sucessor = sucessor + 1;
Console.WriteLine("O sucessor de  " + x + " é  " + sucessor);
Console.ReadKey();

//Desenvolva um algoritmo que solicite a entrada de um número e calcule se o número é par ou impar.

int umNumero = x;
Console.WriteLine("Digite um número!");
umNumero = Convert.ToInt32(Console.ReadLine()); //Lê e converte para int o número informado pelo usuário

if (umNumero % 2 == 0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Impar");
}
Console.ReadKey();


//Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.

String Nome;
Console.WriteLine("Escreva seu Nome!");
Nome = Console.ReadLine();

Console.WriteLine("Meu nome é: " + Nome, "");



//Crie um algoritmo no qual o usuário/aluno deverá  informar seu nome e quatro notas.
// O programama deverá calcular sua média e informar se o aluno foi aprovado ou não.
// O número seis é o valor mínimo para aprovação.

string  N;
float NotaUm = 0;
float NotaDois = 0; 
float NotaTres = 0;
float NotaQuatro = 0;
Console.WriteLine("Escreva seu nome!");
N = Console.ReadLine();
Console.WriteLine("Escreva sua nota do primeiro bimestre");
NotaUm = float.Parse(Console.ReadLine());
Console.WriteLine("Escreva sua nota do segunda bimestre");
NotaDois = float.Parse(Console.ReadLine());
Console.WriteLine("Escreva sua nota do terceiro bimestre");
NotaDois = float.Parse(Console.ReadLine());
Console.WriteLine("Escreva sua nota do quarto bimestre");
NotaQuatro = float.Parse(Console.ReadLine());
float Soma = (NotaUm + NotaDois + NotaTres + NotaQuatro) / 4;
if (Soma > 6)
{
    Console.WriteLine("O ALUNO " + N + " FOI APROVADO. \nSUA MÉDIA FINAL FOI " + Soma);
}
else
{
    Console.WriteLine("O ALUNO " + N + " FOI Reprovado. \nSUA MÉDIA FINAL FOI " + Soma);
}
Console.ReadLine();

//
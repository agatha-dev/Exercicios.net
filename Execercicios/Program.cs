using DotLiquid.Util;
using System.Globalization;
using System.Globalization;


////digite um número e encontre o sucessor dele

int x, sucessor = 0;

Console.WriteLine("Digite um número!");

x = int.Parse(Console.ReadLine());

sucessor = x;
sucessor = sucessor + 1;
Console.WriteLine("O sucessor de  " + x + " é  " + sucessor);
Console.ReadKey();

////Desenvolva um algoritmo que solicite a entrada de um número e calcule se o número é par ou impar.

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


////Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.

String Nome;
Console.WriteLine("Escreva seu Nome!");
Nome = Console.ReadLine();

Console.WriteLine("Meu nome é: " + Nome, "");



////Crie um algoritmo no qual o usuário/aluno deverá  informar seu nome e quatro notas.
//// O programama deverá calcular sua média e informar se o aluno foi aprovado ou não.
//// O número seis é o valor mínimo para aprovação.

string N;
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

////Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
////mensagem explicativa, conforme exemplos



Console.WriteLine("Escreva um valor:");
int valor = 0;
valor = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o segundo valor:");
int valorUm = 0;
valorUm = int.Parse(Console.ReadLine());
float soma = (valor + valorUm);
Console.WriteLine("A soma é " + soma);

////Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
////casas decimais conforme exemplos.Fórmula da área: area = π.raio2
////Considere o valor de π = 3.14159

double r, a, pi = 3.14159;

r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

a = pi * r * r;

Console.WriteLine("A=" + a.ToString("F4", CultureInfo.InvariantCulture));

////Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
////de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

int A = 0;
Console.WriteLine("Digite um valor inteiro:");
A = int.Parse(Console.ReadLine());
int B = 0;
Console.WriteLine("Digite um valor inteiro:");
B = int.Parse(Console.ReadLine());
int C = 0;
Console.WriteLine("Digite um valor inteiro:");
C = int.Parse(Console.ReadLine());
int D = 0;
Console.WriteLine("Digite um valor inteiro:");
D = int.Parse(Console.ReadLine());
double calculo;
calculo = (A * B - C * D);
Console.WriteLine("A diferença do produto é " + calculo);


//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
//hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
//decimais

int numbr = 0;
Console.WriteLine("Digite seu número de funcionário:");
numbr = int.Parse(Console.ReadLine());
int horas = 0;
Console.WriteLine("Digite suas horas trabalhadas:");
horas = int.Parse(Console.ReadLine());
int valor = 0;
Console.WriteLine("Digit quanto você ganha por hora:");
valor = int.Parse(Console.ReadLine());
int calculo = (horas * valor);
Console.WriteLine("Seu salário é de:" + calculo);

//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
//código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.




int cod1, cod2, qte1, qte2;
double preco1, preco2, total;

string[] valores = Console.ReadLine().Split(' ');
cod1 = int.Parse(valores[0]);
qte1 = int.Parse(valores[1]);
preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

valores = Console.ReadLine().Split(' ');
cod2 = int.Parse(valores[0]);
qte2 = int.Parse(valores[1]);
preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

total = preco1 * qte1 + preco2 * qte2;

Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
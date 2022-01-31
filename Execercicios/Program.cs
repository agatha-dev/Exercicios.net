using dotliquid.util;
using system.globalization;
using system.globalization;
using System;


//////digite um número e encontre o sucessor dele

int x, sucessor = 0;

console.writeline("digite um número!");

x = int.parse(Console.readline());

sucessor = x;
sucessor = sucessor + 1;
console.writeline("o sucessor de  " + x + " é  " + sucessor);
console.readkey();

//////desenvolva um algoritmo que solicite a entrada de um número e calcule se o número é par ou impar.

int umnumero = x;
console.writeline("digite um número!");
umnumero = convert.toint32(console.readline()); //lê e converte para int o número informado pelo usuário

if (umnumero % 2 == 0)
{
    console.writeline("par");
}
else
{
    console.writeline("impar");
}
console.readkey();


//////desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.

string nome;
console.writeline("escreva seu nome!");
nome = console.readline();

console.writeline("meu nome é: " + nome, "");



//////crie um algoritmo no qual o usuário/aluno deverá  informar seu nome e quatro notas.
////// o programama deverá calcular sua média e informar se o aluno foi aprovado ou não.
////// o número seis é o valor mínimo para aprovação.

string n;
float notaum = 0;
float notadois = 0;
float notatres = 0;
float notaquatro = 0;
console.writeline("escreva seu nome!");
n = console.readline();
console.writeline("escreva sua nota do primeiro bimestre");
notaum = float.parse(console.readline());
console.writeline("escreva sua nota do segunda bimestre");
notadois = float.parse(console.readline());
console.writeline("escreva sua nota do terceiro bimestre");
notadois = float.parse(console.readline());
console.writeline("escreva sua nota do quarto bimestre");
notaquatro = float.parse(console.readline());
float soma = (notaum + notadois + notatres + notaquatro) / 4;
if (soma > 6)
{
    console.writeline("o aluno " + n + " foi aprovado. \nsua média final foi " + soma);
}
else
{
    console.writeline("o aluno " + n + " foi reprovado. \nsua média final foi " + soma);
}
console.readline();

//////faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
//////mensagem explicativa, conforme exemplos



console.writeline("escreva um valor:");
int valor = 0;
valor = int.parse(console.readline());
console.writeline("escreva o segundo valor:");
int valorum = 0;
valorum = int.parse(console.readline());
float soma = (valor + valorum);
console.writeline("a soma é " + soma);

//////faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
//////casas decimais conforme exemplos.fórmula da área: area = π.raio2
//////considere o valor de π = 3.14159

double r, a, pi = 3.14159;

r = double.parse(console.readline(), cultureinfo.invariantculture);

a = pi * r * r;

console.writeline("a=" + a.tostring("f4", cultureinfo.invariantculture));

//////fazer um programa para ler quatro valores inteiros a, b, c e d. a seguir, calcule e mostre a diferença do produto
//////de a e b pelo produto de c e d segundo a fórmula: diferenca = (a * b - c * d).

int a = 0;
console.writeline("digite um valor inteiro:");
a = int.parse(console.readline());
int b = 0;
console.writeline("digite um valor inteiro:");
b = int.parse(console.readline());
int c = 0;
console.writeline("digite um valor inteiro:");
c = int.parse(console.readline());
int d = 0;
console.writeline("digite um valor inteiro:");
d = int.parse(console.readline());
double calculo;
calculo = (a * b - c * d);
console.writeline("a diferença do produto é " + calculo);


////fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
////hora e calcula o salário desse funcionário. a seguir, mostre o número e o salário do funcionário, com duas casas
////decimais

int numbr = 0;
console.writeline("digite seu número de funcionário:");
numbr = int.parse(console.readline());
int horas = 0;
console.writeline("digite suas horas trabalhadas:");
horas = int.parse(console.readline());
int valor = 0;
console.writeline("digit quanto você ganha por hora:");
valor = int.parse(console.readline());
int calculo = (horas * valor);
////console.writeline("seu salário é de:" + calculo);

////fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
////código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. calcule e mostre o valor a ser pago.




int cod1, cod2, qte1, qte2;
double preco1, preco2, total;

string[] valores = console.readline().split(' ');
cod1 = int.parse(valores[0]);
qte1 = int.parse(valores[1]);
preco1 = double.parse(valores[2], cultureinfo.invariantculture);

valores = console.readline().split(' ');
cod2 = int.parse(valores[0]);
qte2 = int.parse(valores[1]);
preco2 = double.parse(valores[2], cultureinfo.invariantculture);

total = preco1 * qte1 + preco2 * qte2;

console.writeline("valor a pagar: r$ " + total.tostring("f2", cultureinfo.invariantculture));

////fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

int x;
console.writeline("digite um número:");
x = int.parse(console.readline());
if (x < 0)
{
    console.writeline("negativo");
}
else
{
    console.writeline("não negativo");
}
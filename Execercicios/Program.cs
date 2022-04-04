using Exercicios;
using System.Globalization;


//digite um número e encontre o sucessor dele

int x, sucessor = 0;
Console.WriteLine("digite um número!");
x = int.Parse(Console.ReadLine());

sucessor = x;
sucessor = sucessor + 1;
Console.WriteLine("o sucessor de  " + x + " é  " + sucessor);
Console.ReadKey();

//desenvolva um algoritmo que solicite a entrada de um número e calcule se o número é par ou impar.

int umnumero = x;
Console.WriteLine("digite um número!");
umnumero = Convert.ToInt32(Console.ReadLine()); //lê e converte para int o número informado pelo usuário

if (umnumero % 2 == 0)
{
    Console.WriteLine("par");
}
else
{
    Console.WriteLine("impar");
}
Console.ReadKey();


//desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.

string nome;
Console.WriteLine("escreva seu nome:");
nome = Console.ReadLine();

Console.WriteLine("meu nome é: " + nome, "");



//crie um algoritmo no qual o usuário/aluno deverá  informar seu nome e quatro notas.
// o programama deverá calcular sua média e informar se o aluno foi aprovado ou não.
// o número seis é o valor mínimo para aprovação.

string n;
float notaum = 0;
float notadois = 0;
float notatres = 0;
float notaquatro = 0;
Console.WriteLine("escreva seu nome!");
n = Console.ReadLine();
Console.WriteLine("escreva sua nota do primeiro bimestre");
notaum = float.Parse(Console.ReadLine());
Console.WriteLine("escreva sua nota do segunda bimestre");
notadois = float.Parse(Console.ReadLine());
Console.WriteLine("escreva sua nota do terceiro bimestre");
notadois = float.Parse(Console.ReadLine());
Console.WriteLine("escreva sua nota do quarto bimestre");
notaquatro = float.Parse(Console.ReadLine());
float soma = (notaum + notadois + notatres + notaquatro) / 4;
if (soma > 6)
{
    Console.WriteLine("o aluno " + n + " foi aprovado. \nsua média final foi " + soma);
}
else
{
    Console.WriteLine("o aluno " + n + " foi reprovado. \nsua média final foi " + soma);
}
Console.ReadLine();

//faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
//mensagem explicativa, conforme exemplos

Console.WriteLine("escreva um valor:");
int valor = 0;
valor = int.Parse(Console.ReadLine());
Console.WriteLine("escreva o segundo valor:");
int valorum = 0;
valorum = int.Parse(Console.ReadLine());
float somaA = (valor + valorum);
Console.WriteLine("a soma é " + somaA);

//faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
//casas decimais conforme exemplos.fórmula da área: area = π.raio2
//considere o valor de π = 3.14159

double r, a, pi = 3.14159;

r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

a = pi * r * r;

Console.WriteLine("a=" + a.ToString("f4", CultureInfo.InvariantCulture));

//fazer um programa para ler quatro valores inteiros a, b, c e d. a seguir, calcule e mostre a diferença do produto
//de a e b pelo produto de c e d segundo a fórmula: diferenca = (a * b - c * d).

int aU = 0;
Console.WriteLine("digite um valor inteiro:");
aU = int.Parse(Console.ReadLine());
int b = 0;
Console.WriteLine("digite um valor inteiro:");
b = int.Parse(Console.ReadLine());
int c = 0;
Console.WriteLine("digite um valor inteiro:");
c = int.Parse(Console.ReadLine());
int d = 0;
Console.WriteLine("digite um valor inteiro:");
d = int.Parse(Console.ReadLine());
double calculo;
calculo = (a * b - c * d);
Console.WriteLine("a diferença do produto é " + calculo);


//fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
///hora e calcula o salário desse funcionário. a seguir, mostre o número e o salário do funcionário, com duas casas
//decimais

int numbr = 0;
Console.WriteLine("digite seu número de funcionário:");
numbr = int.Parse(Console.ReadLine());
int horas = 0;
Console.WriteLine("digite suas horas trabalhadas:");
horas = int.Parse(Console.ReadLine());
int valorP = 0;
Console.WriteLine("digit quanto você ganha por hora:");
valorP = int.Parse(Console.ReadLine());
int calculoP = (horas * valorP);
Console.WriteLine("seu salário é de:" + calculo);


//fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
//código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. calcule e mostre o valor a ser pago.


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

Console.WriteLine("valor a pagar: r$ " + total.ToString("f2", CultureInfo.InvariantCulture));

//fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

int xU = 0;
Console.WriteLine("digite um número:");
xU = int.Parse(Console.ReadLine());
if (x < 0)
{
    Console.WriteLine("negativo");
}
else
{
    Console.WriteLine("não negativo");
}

//armazene o valor double em saldo e desconte em saque e mostre com uma mensagem quanto restou na conta

double saldo = 0;
Console.WriteLine("Digite o valor do seu saldo:");
saldo = double.Parse(Console.ReadLine());
double valorSaque = 0;
Console.WriteLine("Digite quanto você quer sacar:");
valorSaque = double.Parse(Console.ReadLine());
saldo = saldo - valorSaque;
Console.WriteLine("Seu saldo atual é de: " + saldo);

//exiba um nome

string nomeP = "Ágatha seja bem-vinda!";
Console.WriteLine(nomeP);

//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
int N = 0;
Console.WriteLine("Digite um número: ");
N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Impar");
}
Console.ReadKey();

//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
//incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
//impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002


int senha = int.Parse(Console.ReadLine());

while (senha != 2002)
{
    Console.WriteLine("Acesso negado");
}
Console.WriteLine("Acesso permitido");

//DIGA QUAL O TRIANGULO MAIOR 

Triangulo x1, y2;

x1 = new Triangulo();
y2 = new Triangulo();
double xA, xB, xC, yA, yB, yC;

Console.WriteLine("Entre com as medidas do triangulo x:");
x1.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x1.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x1.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo y:");
y2.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y2.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y2.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (x1.A + x1.B + x1.C) / 2.0;
double areaX = Math.Sqrt(p * (p - x1.A) * (p - x1.B) * (p - x1.C));

p = (y2.A + y2.B + y2.C) / 2.0;
double areaY = Math.Sqrt(p * (p - y2.A) * (p - y2.B) * (p - y2.C));

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior área: X:");
}
else
{
    Console.WriteLine("Maior área: Y");
}

//Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.


Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
p1.Nome = Console.ReadLine();
Console.WriteLine("Idade: ");
p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
p2.Nome = Console.ReadLine();
Console.WriteLine("Idade: ");
p2.Idade = int.Parse(Console.ReadLine());

if (p1.Idade > p2.Idade)
{
    Console.WriteLine("A pessoa mais velha é: " + p1.Nome);
}
else
{
    Console.WriteLine("A pessoa mais velha é: " + p2.Nome);
}

//Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
//médio dos funcionários.


Pessoa p3 = new Pessoa();
Pessoa p4 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
p3.Nome = Console.ReadLine();
Console.WriteLine("Salario: ");
p3.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
p4.Nome = Console.ReadLine();
Console.WriteLine("Salario: ");
p4.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (p3.Salario + p4.Salario) / 2;
Console.WriteLine("Salario médio é: " + media.ToString("F2", CultureInfo.InvariantCulture));


///Peça para entrar com o nome, quantidade de produto e dps quanto vai adicionar e retirar

Produto pr = new Produto();

Console.WriteLine("Entre com os produtos: ");
Console.Write("Nome: ");
pr.NomeProduto = Console.ReadLine();
Console.Write("Preço: ");
pr.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
pr.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do Produto: " + pr);
Console.WriteLine();
Console.Write("Digite o número de produtos  a ser adicionado no estoque: ");
int qte = int.Parse(Console.ReadLine());
pr.AdicionarProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + pr);

Console.WriteLine();
Console.Write("Digite o número de produtos  a ser removidos no estoque: ");
qte = int.Parse(Console.ReadLine());
pr.RemoverProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + pr);



//Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário, se for menor que 18 anos exiba na
//  cor vermelha “Sem permissão”, caso seja maior ou igual a 18 anos exiba na cor verde “Permissão concedida”.

Console.WriteLine("Entre com sua idade: ");
int idade = int.Parse(Console.ReadLine());
if (idade > 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Permissão concedida");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Sem permissão");
}


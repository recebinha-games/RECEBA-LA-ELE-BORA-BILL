/*
Console.WriteLine ("Qual teu nome?");

var info = Console.ReadLine();

Console.WriteLine ("Olá, " + info + ", digite o valor de a:");


var a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite agora o valor de b: ");
var b = int.Parse(Console.ReadLine());

Console.WriteLine("A some de A e B é: " + (a + b)); */

Console.WriteLine("Digite um numero: ");
int num = int.Parse(Console.ReadLine());
bool par = ((num % 2) == 0);

if(par)
{
    Console.WriteLine("é par");
}
else
{
    Console.WriteLine("é impar");
}
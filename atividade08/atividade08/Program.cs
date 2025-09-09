// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um valor");
int numero = int.Parse(Console.ReadLine());
if (numero == 0)
{
    Console.WriteLine("Não permitimos o valor 0");
}

if (numero > 0)
{
    Console.WriteLine("Esse valor é positivo");
}

if (numero <0)
{
    Console.WriteLine("Esse valor é negativo");
}
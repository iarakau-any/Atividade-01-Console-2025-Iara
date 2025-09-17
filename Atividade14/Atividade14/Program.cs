// See https://aka.ms/new-console-template for more information
int num;
Console.WriteLine("Digite um valor:");
num = int.Parse(Console.ReadLine());
for (int contador = 2; contador < num; contador++)
{
    Console.WriteLine(contador);
}



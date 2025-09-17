// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite um numero:");
 int num = int.Parse(Console.ReadLine());
int fatorial = 1;
for (int contador = 1; contador <= num; contador++)
{

    if (num == 0)
    {
        Console.WriteLine("0 = 1, por definição");
    }
    else
    {
        fatorial *= contador;
    }

}
if(num < 0) 
{
    Console.WriteLine("Negativo = não existe!");
}
else
{
    Console.WriteLine(fatorial);
}
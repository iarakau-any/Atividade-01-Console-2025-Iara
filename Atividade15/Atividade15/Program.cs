// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

int resultado;
//int = resultado;
for(int contador = 1000; contador <= 2000; contador++)
{
    resultado = contador % 11;
    if (resultado == 5)
    {
        Console.WriteLine(contador);
    }
}

// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("=== CALCULADORA DE PREÇO DE MAÇÃS ===");
Console.WriteLine("Preço: R$1,30 cada (menos de 12 unidades)");
Console.WriteLine("Preço: R$1,00 cada (12 unidades ou mais)");
Console.WriteLine("--------------------------------------");
Console.Write("Digite o número de maçãs compradas: ");
int numeroMacas = int.Parse(Console.ReadLine());
double custoTotal;
  if (numeroMacas < 12)
       {
            custoTotal = numeroMacas * 1.30;
       }
  else
       {
            custoTotal = numeroMacas * 1.00;
       }
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Número de maçãs: {numeroMacas}");
Console.WriteLine($"Preço unitário: R${(numeroMacas < 12 ? "1,30" : "1,00")}");
Console.WriteLine($"Custo total: R${custoTotal:F2}");


// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("=== SISTEMA DE AVALIAÇÃO ===");
Console.WriteLine("Média mínima para aprovação: 6,0");
Console.WriteLine("----------------------------");

Console.Write("Digite a nota da 1ª avaliação: ");
int nota1 = int.Parse(Console.ReadLine());

Console.Write("Digite a nota da 2ª avaliação: ");
int nota2 = int.Parse(Console.ReadLine());

double media = (nota1 + nota2) / 2;

 string situacao = media >= 6 ? "APROVADO" : "REPROVADO";

            
Console.WriteLine("----------------------------");
Console.WriteLine($"Nota 1ª avaliação: {nota1:F1}");
Console.WriteLine($"Nota 2ª avaliação: {nota2:F1}");
Console.WriteLine($"Média calculada: {media:F1}");
Console.WriteLine($"Situação: {situacao}");


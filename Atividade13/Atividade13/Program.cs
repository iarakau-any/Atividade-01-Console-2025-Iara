﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("=== ORDENAÇÃO DE TRÊS VALORES ===");
Console.WriteLine("Digite três valores diferentes");
Console.WriteLine("-------------------------------");

Console.WriteLine("Digite o primeiro valor: ");
int valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
int valor2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor: ");
int valor3 = int.Parse(Console.ReadLine());

if (valor1 == valor2 || valor1 == valor3 || valor2 == valor3)
{
    Console.WriteLine("Erro: Todos os valores devem ser diferentes!");
    return;
}


double menor, meio, maior;

if (valor1 < valor2 && valor1 < valor3)
{
    menor = valor1;
    if (valor2 < valor3)
    {
        meio = valor2;
        maior = valor3;
    }
    else
    {
        meio = valor3;
        maior = valor2;
    }
}
else if (valor2 < valor1 && valor2 < valor3)
{
    menor = valor2;
    if (valor1 < valor3)
    {
        meio = valor1;
        maior = valor3;
    }
    else
    {
        meio = valor3;
        maior = valor1;
    }
}
else
{
    menor = valor3;
    if (valor1 < valor2)
    {
        meio = valor1;
        maior = valor2;
    }
    else
    {
        meio = valor2;
        maior = valor1;
    }
}

Console.WriteLine("-------------------------------");
Console.WriteLine($"Valores originais: {valor1}, {valor2}, {valor3}");
Console.WriteLine($"Em ordem crescente: {menor}, {meio}, {maior}");

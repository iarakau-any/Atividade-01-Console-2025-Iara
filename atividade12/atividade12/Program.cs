// See https://aka.ms/new-console-template for more information
Console.WriteLine("=== MAIOR VALOR ===");
Console.Write("Digite o primeiro valor: ");
double valor1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
double valor2 = double.Parse(Console.ReadLine());

if (valor1 == valor2)
{
    Console.WriteLine("Erro: Os valores não podem ser iguais!");
    return;
}
if (valor1 > valor2)
{
    Console.WriteLine($"O maior valor é: {valor1}");
}
else
{
    Console.WriteLine($"O maior valor é: {valor2}");
}
// See https://aka.ms/new-console-template for more information
//O programa é uma calculadora simples

char continuar;
do
{
    Console.WriteLine("Escolha a operação (1-Soma, 2-Subtração, 3-Multiplicação, 4-Divisão):");
    int operacao = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite dois números:");
    double num1 = double.Parse(Console.ReadLine());
    double num2 = double.Parse(Console.ReadLine());
    double resultado = 0;

    switch (operacao)
    {
        case 1:
            resultado = num1 + num2;
            break;
        case 2:
            resultado = num1 - num2;
            break;
        case 3:
            resultado = num1 * num2;
            break;
        case 4:
            if (num2 != 0)
                resultado = num1 / num2;
            else
                Console.WriteLine("Divisão por zero!");
            break;
        default:
            Console.WriteLine("Operação inválida!");
            break;
    }

    Console.WriteLine($"Resultado: {resultado}");
    Console.WriteLine("Deseja continuar? (s/n)");
    continuar = char.Parse(Console.ReadLine());
}
while (continuar == 's' || continuar == 'S');
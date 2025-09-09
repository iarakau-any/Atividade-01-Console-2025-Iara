// See https://aka.ms/new-console-template for more information
Console.WriteLine("=== VERIFICADOR DE VOTO ===");
Console.Write("Digite o ano atual: ");
int anoAtual = int.Parse(Console.ReadLine());

Console.Write("Digite o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

int idade = anoAtual - anoNascimento;

Console.WriteLine($"\nIdade: {idade} anos");

if (idade < 16)
{
    Console.WriteLine("Situação: NÃO VOTA");
}
else if (idade < 18 || idade > 70)
{
    Console.WriteLine("Situação: VOTO FACULTATIVO");
}
else
{
    Console.WriteLine("Situação: VOTO OBRIGATÓRIO");
}

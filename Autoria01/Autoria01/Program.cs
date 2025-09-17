// See https://aka.ms/new-console-template for more information
//O programa tem um objetivo, que é determinar o IMC de uma pessoa através da sua altura e seu peso
//INFORMAÇÕES NESCESSARIAS : peso(kg) e altura(m)

using System.ComponentModel.Design;

Console.WriteLine("Oi, tudo bem?, vamos olha seu IMC ");
Console.WriteLine("Me diga o seu peso(kg): ");
double peso = double.Parse(Console.ReadLine());
Console.WriteLine("ok, agora me diga sua altura(m): ");
double altura = double.Parse(Console.ReadLine());
double imc = 0;

if (peso <= 0 || altura <= 0)
{
    Console.WriteLine("Erro: Peso e altura devem ser valores positivos.");
}
else
{
    imc = peso / (altura * altura);
    Console.WriteLine($"\nSeu IMC é: {imc} ");
}
if (imc < 18.5)
{
    Console.WriteLine("Classificação: Abaixo do peso");
}
else if (imc < 25)
{
    Console.WriteLine("Classificação: Peso normal");
}
else if (imc < 30)
{
    Console.WriteLine("Classificação: Sobrepeso");
}
else if (imc < 35)
{
    Console.WriteLine("Classificação: Obesidade Grau I");
}
else if (imc < 40)
{
    Console.WriteLine("Classificação: Obesidade Grau II");
}
else
{
    Console.WriteLine("Classificação: Obesidade Grau III");
}
   
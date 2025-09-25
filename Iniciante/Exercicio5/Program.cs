using System;

class Program
{
    static void CalculoFatorial(int numero)
    {
        int fatorial = 1;

        for (int i = 0; i > 1; i--)
        {
            fatorial *= numero;
            Console.WriteLine($"O fatorial do número {numero} é {fatorial}.");
        }
    }

    static void Main()
    {
        string continuar;
        Console.WriteLine("Programa que gera o fatorial do numero selecionado pelo usuario.");

        do
        {
            Console.WriteLine("Escolha um numero: ");
            int numero = int.Parse(Console.ReadLine());

            CalculoFatorial(numero);

            Console.WriteLine("Deseja Continuar o programa (S/N): ");
            continuar = Console.ReadLine();
            continuar = continuar.UpperLower();
        } while (continuar != "N");
    }
}
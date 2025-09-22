using System;

class Program
{
    static void Main()
    {
        //declaração das variaveis
        int par = 0, impar = 0;


        //apresentaçãao e escolha da quantidade de numeros para a verificação
        Console.WriteLine("=== Verificação de Números Pares e Ímpares ===");

        Console.Write("Quantos números você deseja verificar? ");
        int qtdNumeros;
        while (!int.TryParse(Console.ReadLine(), out qtdNumeros) || qtdNumeros <= 0)
        {
            Console.Write("⚠ Digite um número inteiro positivo: ");
        }

        Console.Clear();

        //lógica para fazer a verificação de numeros pares e impares 
        for (int i = 0; i < qtdNumeros; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("⚠ Entrada inválida. Digite um número inteiro: ");
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine($"➡ O número {numero} é PAR.\n");
                par++;
            }
            else
            {
                Console.WriteLine($"➡ O número {numero} é ÍMPAR.\n");
                impar++;
            }
        }

        //apresentação dos dados obtidos pelo programa
        Console.WriteLine($"\nResumo da verificação:");
        Console.WriteLine($"🔹 Total de números: {qtdNumeros}");
        Console.WriteLine($"🔹 Pares: {par}");
        Console.WriteLine($"🔹 Ímpares: {impar}");
    }
}
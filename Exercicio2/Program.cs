using System;

class Program
{
    static void Main()
    {
        int resultado = 0;

        Console.WriteLine("Programa que faz a tabuda de N número de 1 a 10.");

        bool continuar;
        do
        {
            continuar = true;
            Console.WriteLine("Digite um numero N para calcular a tabuada dele: ");
            int numTabuada = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                resultado = i * numTabuada;
                Console.WriteLine($"{i} X {numTabuada} = {resultado}");
            }

            Console.WriteLine("Deseja Continuar (S / N): ");
            string resposta = Console.ReadLine().ToLower();
            continuar = (resposta == "s");
        } while (continuar != false);

        Console.WriteLine("Encerrando o programa...👏");
    }
}
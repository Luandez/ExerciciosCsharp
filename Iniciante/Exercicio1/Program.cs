using System;

class Program
{
    static void Main()
    {
        bool continuar = true;
        double memoria = 0; // armazena o último resultado
        bool usarMemoria = false; // indica se vou usar memória

        while (continuar)
        {
            Console.WriteLine("\n=== CALCULADORA ===");
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Soma (+)");
            Console.WriteLine("2 - Subtração (-)");
            Console.WriteLine("3 - Multiplicação (*)");
            Console.WriteLine("4 - Divisão (/)");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 5)
            {
                continuar = false;
                Console.WriteLine("Encerrando a calculadora... 👋");
                break;
            }

            Console.Write("Quantos números deseja calcular? ");
            int qtd = int.Parse(Console.ReadLine());

            double resultado = 0;

            for (int i = 0; i < qtd; i++)
            {
                double numero;

                if (i == 0 && usarMemoria)
                {
                    // Se estiver usando memória, o resultado anterior vira o primeiro número
                    numero = memoria;
                    Console.WriteLine($"(Usando memória: {numero})");
                    resultado = numero;
                }
                else
                {
                    Console.Write($"Digite o {i + 1}º número: ");
                    numero = double.Parse(Console.ReadLine());

                    if (i == 0 && !usarMemoria)
                        resultado = numero; // inicializa com o primeiro número
                    else
                    {
                        switch (opcao)
                        {
                            case 1: resultado += numero; break;
                            case 2: resultado -= numero; break;
                            case 3: resultado *= numero; break;
                            case 4:
                                if (numero != 0) resultado /= numero;
                                else Console.WriteLine("⚠ Não é possível dividir por zero!");
                                break;
                            default: Console.WriteLine("⚠ Opção inválida!"); break;
                        }
                    }
                }
            }

            Console.WriteLine($"\nResultado final: {resultado}");
            memoria = resultado; // guarda o último resultado

            // Perguntar se o usuário quer usar memória na próxima operação
            Console.Write("\nDeseja usar este resultado na próxima operação? (s/n): ");
            string resp = Console.ReadLine().ToLower();
            usarMemoria = (resp == "s");
        }
    }
}
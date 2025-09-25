using System;

class Program
{
    //Funções que eu criei para realizar os calculos e deixar o codigo mais limpo e legivel
    static void CalculoQuadrado(double lado)
    {
        double valorQuadrado = lado * lado;
        Console.WriteLine($"O valor do quadrado: {valorQuadrado}.");
    }

    static void CalculoRetangulo(double base1, double altura)
    {
        double valorRetangulo = base1 * altura;
        Console.WriteLine($"O valor do retangulo: {valorRetangulo}.");
    }

    static void Circulo(double raio)
    {
        double valorCirculo = Math.PI * (Math.Pow(raio, 2));
        Console.WriteLine($"O valor do circulo: {valorCirculo:f2}.");
    }

    static void Main()
    {
        //Declaração das variaveis para usar de parametros
        double num1, num2;
        string continuar;


        do
        {
            //apresentação do programa
            Console.WriteLine("Programa que faz calculo do (quadrado / retangulo / raio)");
            Console.WriteLine("Escolha um calculo: ");
            string escolha = Console.ReadLine();
            escolha = escolha.ToLower();

            //switch para tomar a decisão de qual calculo fazer (quadrado - retangulo ou raio)
            switch (escolha)
            {
                case "quadrado":
                    Console.WriteLine("Escolha o primeiro numero: ");
                    num1 = double.Parse(Console.ReadLine());
                    CalculoQuadrado(num1);
                    break;
                case "retangulo":
                    Console.WriteLine("Escolha o primeiro numero: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Escolha o segundo numero: ");
                    num2 = double.Parse(Console.ReadLine());
                    CalculoRetangulo(num1, num2);
                    break;
                case "raio":
                    Console.WriteLine("Escolha o primeiro numero: ");
                    num1 = double.Parse(Console.ReadLine());
                    Circulo(num1);
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida.");
                    break;
            }
            Console.WriteLine("Deseja continuar o programa: ");
            continuar = Console.ReadLine();
        } while (continuar != "n");
    }
}
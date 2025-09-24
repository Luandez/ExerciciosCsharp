using System;

class Program
{
    static void ExibirMsg()
    {
        Console.WriteLine("Ola tudo bem?");
        Console.WriteLine("Testando");
    }

    static void ExibirValor(int preco, string nome)
    {
        Console.WriteLine(preco);
        Console.WriteLine($"O nome do cliente: {nome}");
    }

    static void Main()
    {
        ExibirMsg();
        ExibirValor(20, "Luan");
    }
}
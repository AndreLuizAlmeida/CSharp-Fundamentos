using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double media;
            media = (num1 + num2) / 2;

            Console.WriteLine($"A média entre os valores {num1} e {num2} é {media}");
        }
    }
}
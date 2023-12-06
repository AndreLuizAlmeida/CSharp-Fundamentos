using System;

namespace MediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            int peso1;
            int peso2;
            double media;
            
            Console.WriteLine("Informe a primeira nota: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o peso: ");
            peso1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o peso: ");
            peso2 = Convert.ToInt32(Console.ReadLine());

            media = (num1 * peso1 + num2 * peso2)/(peso1+peso2) ;
            Console.WriteLine($"A meda ponderada dos valores {num1} e {num2} com pesos {peso1},{peso2} é {media}");
        }
    }
}
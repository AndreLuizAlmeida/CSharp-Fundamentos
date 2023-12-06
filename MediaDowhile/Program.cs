using System;

namespace MediaDowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double contador = 0;
            double num = 0;
            double media = 0;

            do
            {
                Console.WriteLine("Insira um valor (0 para sair)");
                num = Convert.ToDouble(Console.ReadLine());

                if (num == 0)
                {
                    Console.WriteLine($"A media dos valores é {media}");
                }
                total += num;
                contador++;
                media = total / contador;
            } while (num != 0);
        }
    }
}
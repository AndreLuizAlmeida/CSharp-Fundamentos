using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"O número {num} é par");
            }
            else
            {
                Console.WriteLine($"O número {num} é ímpar");
            }
        }
    }
}
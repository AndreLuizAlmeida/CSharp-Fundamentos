using System;

namespace AntecessorSucessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O antecessor de {num} é {num-1} e seu sucessor é {num+1}");
        }
    }
} 
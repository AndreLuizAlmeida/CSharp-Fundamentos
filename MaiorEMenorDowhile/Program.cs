using System;

namespace MaiorEMenorDowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            var maiorValor = 0;
            var menorValor = 9999;

            do
            {
                Console.WriteLine("Insira um valor(0 para sair):");
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    Console.WriteLine($"O maior valor é {maiorValor}");
                    Console.WriteLine($"O menor valor é {menorValor}");
                }
                else if (num > maiorValor)
                {
                    maiorValor = num;
                }
                else if (num < menorValor)
                {
                    menorValor = num;
                }
            } while (num != 0);
        }
    }
}
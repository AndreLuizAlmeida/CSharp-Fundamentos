using System;

namespace MaiorEMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o terceiro numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int maiorValor = 0;
            int menorValor = 0;
            //Definindo maior valor
            if (num1 > num2 && num1 > num3)
            {
                maiorValor = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                maiorValor = num2;
            }
            else
            {
                maiorValor = num3;
            }
            //Definindo menor valor
            if (num1 < num2 && num1 < num3)
            {
                menorValor = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                menorValor = num2;
            }
            else
            {
                menorValor = num3;
            }
            Console.WriteLine($"Entre os números {num1},{num2},{num3} o maior é {maiorValor}");
            Console.WriteLine($"Entre os números {num1},{num2},{num3} o menor é {menorValor}");
        }
    }
}
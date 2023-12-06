using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor do seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Insira o valor do sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine(imc);
            if (imc <= 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            } 
            else if (imc > 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (imc > 25 && imc <= 29.9)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc > 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau 1");
            }
            else if (imc > 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade Grau 2");
            }
            else
            {
                Console.WriteLine("Obesidade Grau 3");
            }
        }
    }
}
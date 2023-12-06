using System;

namespace NumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero;
            int guess;
            String resposta;
            int guesses;
            int min = 1;
            int max = 100;
            bool play = true;

            while (play == true)
            {
                guess = 0;
                guesses = 0;
                resposta = "";
                numero = random.Next(min, max + 1);
                while (guess != numero)
                {
                    Console.WriteLine($"Adivinhe um numero entre {min} - {max}:");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < numero)
                    {
                        Console.WriteLine($"{guess} é menor!");
                    }
                    else if (guess > numero)
                    {
                        Console.WriteLine($"{guess} é maior!");
                    }

                    guesses++;
                }

                Console.WriteLine($"Numero: {numero}");
                Console.WriteLine("VOCE VENCEU!");
                Console.WriteLine($"Tentativas: {guesses}");

                Console.WriteLine("Deseja jogar novamente(S/N):");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                switch (resposta)
                {
                    case "S":
                        play = true;
                        break;
                    case "N":
                        play = false;
                        break;
                }
            }

            Console.WriteLine("Obrigado por jogar");
        }
    }
}
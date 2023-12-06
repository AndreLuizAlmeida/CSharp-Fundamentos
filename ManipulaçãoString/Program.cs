using System;

namespace ManipulaçãoString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira seu nome completo: ");
            String nome = Console.ReadLine();

            Console.WriteLine(nome.Trim());
            Console.WriteLine(nome.Replace(" ",""));
            Console.WriteLine(nome.ToLower());
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.Insert(nome.Length,"WOW"));
            Console.WriteLine(nome.Replace("André",""));
            Console.WriteLine(nome.Contains("André"));
            Console.WriteLine(nome.Replace(" ","").Length);
        }
    }
}
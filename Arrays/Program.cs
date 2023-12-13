using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var meuArray = new int[5]{1,2,3,4,5};

            // for (int i = 0; i < meuArray.Length; i++)
            // {
            //     Console.Write(meuArray[i] + " ");
            //     
            // }
            // foreach (var i in meuArray)
            // {
            //     Console.WriteLine(i);
            // }
            var funcionarios = new Funcionario[5];

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
            }
        }
    }
}

public struct Funcionario
{
    public int Id { get; set; }
}

using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A pessoa {0} tem {1} anos de idade.", nome, Convert.ToString(idade));

            // Windows 👎🏻
            Console.ReadKey();
        }
    }
}

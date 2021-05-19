using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua cidade:");
            string cidade = Console.ReadLine();

            Console.WriteLine("Digite o seu bairro:");
            string bairro = Console.ReadLine();

            Console.WriteLine("A pessoa {0} mora em {1} no bairro {2}", nome, cidade, bairro);

            // Windows 👎🏻
            Console.ReadKey();
        }
    }
}

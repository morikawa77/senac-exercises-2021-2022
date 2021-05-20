using System;

namespace Exercicios20052021
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1==num2) {
                Console.WriteLine("Os números são iguais.");
            } 
            else if (num1>num2) {
                Console.WriteLine($"O primeiro número ({num1}) é maior que o segundo número.");
            } else {
                Console.WriteLine($"O segundo número ({num2}) é maior que o primeiro número.");
            }
        }
    }
}

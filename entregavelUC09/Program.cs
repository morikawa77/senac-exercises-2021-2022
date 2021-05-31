using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Text.Json;

namespace EntregavelUC09
{
    public class Menu
    {
        public void escolhaExercicio() {

            string fileName = "descriptions.json";
            ReadOnlySpan<byte> jsonReadOnlySpan = File.ReadAllBytes(fileName);


            string[] descriptions = JsonSerializer.Deserialize<string[]>(jsonReadOnlySpan);
            List<string> methods = new List<string>();

            int descriptionIterator = 1;
            string methodChoosed;
            int optionTyped;
             
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o número do exercício a ser exibido: ");
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();

            foreach (var item in descriptions)
            {
                if(item == "Sair") {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{descriptionIterator} - {item}");
                    Console.ResetColor();
                } else if (descriptionIterator < 10){
                    Console.WriteLine($"{descriptionIterator}  - {item}");
                    descriptionIterator++;
                } else {
                    Console.WriteLine($"{descriptionIterator} - {item}");
                    descriptionIterator++;
                }
            }

            for (int i = 1; i <= descriptionIterator; i++)
            {
                if (i <= 9) {
                    methods.Add($"exercicio0{i}");
                } else if (i == descriptionIterator){
                    methods.Add("sair");
                } else {
                    methods.Add($"exercicio{i}");
                }
            }

            Console.WriteLine();

            do
            {
                Console.Write("Opção desejada: ");
                methodChoosed = Console.ReadLine();
            } while (Int32.TryParse(methodChoosed, out optionTyped) == false || optionTyped < 1 || optionTyped > descriptionIterator);


            string methodName = methods[optionTyped - 1];
            MethodInfo method = this.GetType().GetMethod(methodName);

            try{
                method.Invoke(this, null);
            } finally {
                escolhaExercicio();
            }
        }

        public void sair() {
            Environment.Exit(0);
        }

        public void exercicio01() {
            int a, b;

            Console.WriteLine("Digite o número a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i <= b; i++)
            {
                Console.WriteLine($"{a*i}");
            }
        }

        public void exercicio02() => Console.WriteLine("Esse é o exercício 02");

        public void exercicio03() {
                Console.WriteLine("Esse é o exercício 03");
        }

        public void exercicio04() {
                Console.WriteLine("Esse é o exercício 04");
        }
        public void exercicio05() {
                Console.WriteLine("Esse é o exercício 05");
        }

        public void exercicio06() {
                Console.WriteLine("Esse é o exercício 06");
        }

        public void exercicio09() {
                Console.WriteLine("Esse é o exercício 09");
        }

        public void exercicio10() {
                Console.WriteLine("Esse é o exercício 10");
        }

        public void exercicio11() {
                Console.WriteLine("Esse é o exercício 11");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.escolhaExercicio();
        }
    }
}
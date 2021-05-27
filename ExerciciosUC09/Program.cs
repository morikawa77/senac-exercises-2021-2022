using System;
using System.Reflection;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExerciciosUC09
{
    public class Exercicios 
    {
        public string method { get; set; }
        public string description { get; set; }
    }

    public class Menu
    {
        public void escolhaExercicio() {

            string fileName = "exercicios.json";
            string jsonString = File.ReadAllText(fileName);
            Exercicios exercicios = JsonConvert.DeserializeObject<Exercicios>(jsonString);
            int descriptionIterator = 1;
            // int methodChoosed;
             
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o número do exercício a ser exibido: ");
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();

            foreach (var item in exercicios.description)
            {
                Console.WriteLine($"{descriptionIterator} - {item}");
                descriptionIterator++;
            }

            // do
            // {
            //     Console.Write("Opção desejada: ");
            //     methodChoosed = Console.ReadLine();
            // } while (Int32.TryParse(methodChoosed, out optionTyped) == false || optionTyped < 1 || optionTyped > descriptionIterator);


            // string methodName = "exercicio01";
            // MethodInfo method = this.GetType().GetMethod(methodName);
          

            // try{
            //     method.Invoke(this, null);
            // } finally {
            //     escolhaExercicio();
            // }
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

            for (int i = 0; i <= b; i++)
            {
                Console.WriteLine($"{a*i}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.escolhaExercicio();

            Console.ReadKey();
        }

        
    }

}

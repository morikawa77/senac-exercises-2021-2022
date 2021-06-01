using System;

namespace exercicioFinalUC09
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, resposta = "";
            double raio, circunferencia;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine($"Olá {nome}! Você é terraplanista?");
            resposta = Console.ReadLine().ToLower();

            while(resposta != "sim" && resposta != "não" && resposta != "nao"){
                Console.WriteLine("Resposta inválida. Tente novamente.");
                Console.WriteLine($"Olá {nome}! Você é terraplanista?");
                resposta = Console.ReadLine().ToLower();
            }

            if(resposta == "sim") {
                Environment.Exit(0);
            } else if(resposta == "não" || resposta == "nao") {
                Console.WriteLine("Digite o raio da Terra:");
                raio = double.Parse(Console.ReadLine());

                circunferencia = 2 * Math.PI * raio;
                Console.WriteLine($"A circunferência da Terra é: {circunferencia}");
                Environment.Exit(0);
            } 

        }
    }
}

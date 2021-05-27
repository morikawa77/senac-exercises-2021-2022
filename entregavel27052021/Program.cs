using System;

namespace entregavel27052021
{
    class Program
    {
        static char escolha;

        static void Main(string[] args)
        {

            do
            {
                escolhaExercicio();

            } while (escolha == 's');

            Console.ReadKey();
        }

        static void escolhaExercicio() {
            int exercicio;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Digite o número do exercício a ser exibido: ");
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("3 - Escreva um programa C# para determinar se um dado número é primo ou não");
            Console.WriteLine("10. Escreva um programa em C# para fazer um padrão como uma pirâmide");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("0 - Sair");
            Console.ResetColor();
            Console.Write("Opção desejada: ");


            exercicio = Convert.ToInt32(Console.ReadLine());

            switch (exercicio)
            {
                case 3:
                    exercicio03();
                    break;
                case 10:
                    exercicio10();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Exercício inválido!");
                    break;
            }

            Console.Write("Deseja ver outro exercício? S ou N ?");
            escolha = Convert.ToChar(Console.ReadLine().ToLower());
            Console.WriteLine("");
        }

        // Escreva um programa C# para determinar se um dado número é primo ou não.
        static void exercicio03() {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            if (chkprime(n))
                Console.WriteLine(n + " é um número primo");
            else
                Console.WriteLine(n + " não é um número primo");

            bool chkprime(int num)
            {
                for (int i = 2; i < num; i++)
                    if (num % i == 0)
                        return false;
                return true;
            }
        }

        // Escreva um programa em C# para fazer um padrão como uma pirâmide com um asterisco.
        // Atenção: O programa deverá solicitar previamente ao usuário a quantidade de linhas que determinará o tamanho da pirâmide.
        static void exercicio10() {
            int num, i, j, k;
            Console.Write("Digite o número de linhas: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();

            }

            Console.WriteLine();
        }
    }
}

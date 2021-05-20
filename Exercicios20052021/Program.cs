using System;

namespace Exercicios20052021
{
    class Program
    {
        static char escolha = 's';

        static void Main(string[] args)
        {

            do
            {
                escolhaExercicio();

            } while (escolha == 's');

            Console.ReadKey();
        }

        static void escolhaExercicio(){
            int exercicio;

            Console.Write("Digite o exercício a ser exibido: ");
            exercicio = Convert.ToInt32(Console.ReadLine());

            switch (exercicio)
            {
                case 1:
                    exercicio01();
                    break;
                case 2:
                    exercicio02();
                    break;
                case 3:
                    exercicio03();
                    break;
                default:
                    Console.WriteLine("Exercício inválido!");
                    break;
            }

            Console.Write("Deseja ver outro exercício? S ou N ?");
            escolha = Convert.ToChar(Console.ReadLine().ToLower());
            Console.WriteLine("");
        }

        static void exercicio01(){
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

        static void exercicio02(){
            int mes;

            Console.WriteLine("Digite o número do seu mês de nascimento:");
            mes = Int32.Parse(Console.ReadLine());

            switch (mes) {
                case 1:
                    Console.WriteLine("Você nasceu em Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Você nasceu em Fevereiro");
                    break;    
                default:
                    Console.WriteLine("Mês inválido.");
                    break;
                }
        }

        static void exercicio03() {
            int opcao;

            Console.WriteLine("Menu");
            Console.WriteLine("1 - Cadastros");
            Console.WriteLine("2 - Vendas");
            Console.WriteLine("3 - Compras");
            Console.WriteLine("4 - Relatórios");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("Digite o número da opção desejada:");
            opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Você selecionou a opção 1 - Cadastros");
                    break;
                case 2:
                    Console.WriteLine("Você selecionou a opção 2 - Vendas");
                    break;
                case 3:
                    Console.WriteLine("Você selecionou a opção 3 - Compras");
                    break;
                case 4:
                    Console.WriteLine("Você selecionou a opção 4 - Relatórios");
                    break;
                case 5:
                    Console.WriteLine("Você selecionou a opção 5 - Sair");
                    break;
                default:
                    Console.WriteLine("Você selecionou uma opção inválida");
                    break;
            }
        }
    }
}

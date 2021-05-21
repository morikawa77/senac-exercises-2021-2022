using System;

namespace Lista21052021
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
                case 4:
                    exercicio04();
                    break;
                case 5:
                    exercicio05();
                    break;
                case 6:
                    exercicio06();
                    break;
                case 7:
                    exercicio07();
                    break;
                case 8:
                    exercicio08();
                    break;
                case 9:
                    exercicio09();
                    break;
                case 10:
                    exercicio10();
                    break;
                case 11:
                    exercicio11();
                    break;
                case 12:
                    exercicio12();
                    break;
                default:
                    Console.WriteLine("Exercício inválido!");
                    break;
            }

            Console.Write("Deseja ver outro exercício? S ou N ?");
            escolha = Convert.ToChar(Console.ReadLine().ToLower());
            Console.WriteLine("");
        }

        // Receba um número A e um número B, e escreva a tabuada do número A até o limite definido no número B.
        static void exercicio01() {
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

        // Leia DEZ valores e calcule e exiba a média entre eles.
        static void exercicio02() {
            int num;
            double soma = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Digite o {i}º número:");
                num = int.Parse(Console.ReadLine());

                soma += num;
            }

            Console.WriteLine($"A média dos números é {soma/10}");
        }

        // Leia 2 valores.
        // Calcule e escreva a soma dos números inteiros pares existentes entre os 2 valores lidos.
        // Considere que o segundo valor lido será sempre maior que o primeiro valor lido.
        static void exercicio03() {
            int num1 = 0, num2 = 0, soma = 0;

            Console.WriteLine("Digite o primeiro número:");
            num1 = int.Parse(Console.ReadLine());

            do {
                Console.WriteLine("Digite o segundo número que seja maior que o primeiro:");
                num2 = int.Parse(Console.ReadLine());
            } while(num2<=num1);

            if (num1 % 2 == 0) {
                soma += num1;
            }

            if (num2 % 2 == 0) {
                soma += num2;
            }

            Console.WriteLine($"A soma dos números pares existentes entre os 2 valores é {soma}.");
        }

        // int[] h = new int[6] {10,35,48,19,76,99};
        // Escreva os valores na sequência e depois na ordem inversa ao mostrado aqui.
        static void exercicio04() {
            int[] h = new int[6] {10,35,48,19,76,99};

            int[] sorted = new int[6];
            Array.Copy(h, sorted, 6);

            Array.Sort(sorted);
            Console.Write("Valores do Array na sequência: ");
            foreach (int i in sorted) {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");

            Array.Reverse(h);
            Console.Write("Valores do array na ordem inversa: ");
            for(int i=0; i<h.Length; i++) {
                Console.Write(h[i] + " ");
            }

            Console.WriteLine("\n");
        }

        // int[] a = new int[7] {10,15,20,25,30,35,40};
        // Escreva a SOMA e a MULTIPLICÇÃO dos valores do vetor a.
        static void exercicio05() {
            int[] a = new int[7] {10,15,20,25,30,35,40};
            int soma = 0;
            double produto = 1;

            foreach (var item in a)
            {
                soma += item;
                produto *= item;
            }

            Console.WriteLine($"A soma dos valores do vetor é: {soma}");
            Console.WriteLine($"O produto dos valores do vetor é: {produto}");
        }

        // Leia 30 valores e no final, escreva o maior e o menor valor lido.
        static void exercicio06() {
            int num, maior, menor;

            Console.WriteLine($"Digite o 1º número:");
            num = int.Parse(Console.ReadLine());
            maior = num;
            menor = num;

            for (int i = 1; i < 30; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número:");
                num = int.Parse(Console.ReadLine());

                if (num < menor) {
                    menor = num;
                }

                if (num > maior) {
                    maior = num;
                }
            }

            Console.WriteLine($"O menor número é {menor}.");
            Console.WriteLine($"O maior número é {maior}.");

        }

        // Ler um valor N e imprimir todos os valores inteiros entre 1 (inclusive) e N (inclusive).
        // Considere que o N será sempre maior que ZERO.
        // Certifique-se de implementar para que aceite somente valores maiores que 0 para N.
        static void exercicio07() {
            int n;

            do {
                Console.WriteLine("Digite um número maior que 0");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            if(n==1) {
                Console.WriteLine("1"); 
            }
            else {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"{i}");
                }
            } 
            
        }

        // Leia 15 números, e calcule: Soma, Subtração e Multiplicação
        // Entre estes números e ao final escreva a Soma, Subtração e Multiplicação resultantes
        static void exercicio08() {
            double num, soma = 0, resto = 0, produto = 1;

            for (int i = 0; i < 15; i++) {
                Console.WriteLine($"Digite o {i+1}º número:");
                num = int.Parse(Console.ReadLine());
                soma += num;
                resto -= num;
                produto *= num;
            }

            Console.WriteLine($"A soma dos números é {soma}.");
            Console.WriteLine($"O resto dos números é {resto}.");
            Console.WriteLine($"O produto dos números é {produto}.");

        }

        // Ler 10 números.
        // Todos os números lidos com valor superior a 20 devem ser somados
        // Todos os números com valor inferior a 10 deverão ser multiplicados.
        // Escrever ao final, o valor da SOMA efetuada e também da MULTIPLICAÇÃO realizada.
        static void exercicio09() {
            double num, soma = 0, produto = 1;

            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"Digite o {i+1}º número:");
                num = int.Parse(Console.ReadLine());

                if(num > 20) {
                    soma += num;
                }

                if(num < 10) {
                    produto *= num;
                }
            }

            Console.WriteLine($"A soma dos números maiores que 20 é {soma}.");
            Console.WriteLine($"O produto dos números menores que 10 é {produto}.");
        }

        // Ler um número e valide para que o número seja maior que 20.
        // Calcule e exiba a Série de Fibonacci até atingir esse número.
        static void exercicio10() {
            int num, a = 0, fib = 1;

            do {
                Console.WriteLine("Digite um número maior que 20");
                num = int.Parse(Console.ReadLine());
            } while (num <= 20);

            while (fib <= num)
            {
                Console.Write(a + " " + fib + " ");
                a += fib;
                fib += a;
            }

            if (a<= num) {
                Console.Write(a);
            }
            
            Console.WriteLine();
        }

        // Ler um número.
        // Calcule e exiba o Fatorial deste número.
        static void exercicio11() {
            double num, a = 0, b = 0, c = 1;

            Console.WriteLine("Digite um número:");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                a = b;
                b = a + 1;
                c = c * b;
            }

            Console.WriteLine($"O valor do fatorial de {num} é {c}");
        }

        // Ler um número N.
        // Calcule e exiba a sequência abaixo até o número digitado como valor para N ser atingido.
        // 1, 4, 9, 16, 25 .... => X = N2
        static void exercicio12() {
            int num;

            Console.WriteLine("Digite um número máximo para a sequência: ");
			num = int.Parse(Console.ReadLine());

            if (num <= 1) {
                Console.WriteLine(1);
            }
            else {
                Console.Write("1 ");
                for (double i = 2, j=2; i*i <= num; i++)
				{
                    j = Math.Pow(i, 2);
                    Console.Write($"{j} ");  
				}
            }

            Console.WriteLine();

        }

    }
}

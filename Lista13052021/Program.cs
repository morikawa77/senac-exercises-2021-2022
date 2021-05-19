using System;

namespace Lista13052021
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
                default:
                    Console.WriteLine("Exercício inválido!");
                    break;
            }

            Console.Write("Deseja ver outro exercício? S ou N ?");
            escolha = Convert.ToChar(Console.ReadLine().ToLower());
            Console.WriteLine("");
        }

        // Receba a Base e Altura de um Retângulo
        // Calcule a Área do Retângulo
        // "A área do Retângulo é [Área]"
        static void exercicio01()
        {
            int baseR, alturaR, areaR;

			Console.WriteLine("Digite o tamanho da base em metros: ");
			baseR = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite o tamanho da altura em metros: ");
			alturaR = Convert.ToInt32(Console.ReadLine());

			areaR = baseR * alturaR;

			Console.WriteLine($"A área do retânagulo é de {areaR} metros.");
			Console.ReadLine();
        }

        // Receba o Nome, Idade e Ano do Casamento de uma Pessoa.
        // Calcule a Idade que ela tinha quando casou
        // "[Nome], você tinha [Idade Casamento] quando se casou em [Ano do Casamento]"
        static void exercicio02()
        {
            string nome;
			int idadeAtual, idadeCasamento, anoCasamento, anoAtual, difAnos;

			anoAtual = DateTime.Now.Year;

			Console.WriteLine("Digite seu nome: ");
			nome = Console.ReadLine();

			Console.WriteLine("Digite sua idade atual: ");
			idadeAtual = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite o ano do seu casamento: ");
			anoCasamento = Convert.ToInt32(Console.ReadLine());

			difAnos = anoAtual - anoCasamento;
			idadeCasamento = idadeAtual - difAnos;

			Console.Write($"{nome}, você tinha {idadeCasamento} quando se casou em {anoCasamento}");
			Console.ReadLine();
        }

        // Receba o Raio de um Círculo
        // Calcule a Circunferência e a Área do Círculo
        // "A área do Circulo é [Área], e sua circunferência é [Circunferência]"
        static void exercicio03()
        {
            double circ, area, raio;

			Console.WriteLine("Digite o raio do círculo: ");
            raio = Convert.ToDouble(Console.ReadLine());

            circ = 2 * Math.PI * raio;
            area = Math.PI * Math.Pow(raio, 2);

			Console.Write($"A área do Círculo é {area}, e sua circunferência é {circ}");
			Console.ReadLine();
        }

        // Receba a Base e Altura de um Triângulo
        // Calcule a Área do Triângulo
        // "A Área do Triângulo é [Área]"
        static void exercicio04()
        {
            double baseT, altT, areaT;

			Console.WriteLine("Digite a base do triângulo: ");
			baseT = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Digite a altura do triângulo: ");
			altT = Convert.ToDouble(Console.ReadLine());

            areaT = 0.5 * (baseT * altT);

			Console.Write($"A área do triângulo é {areaT}");
			Console.ReadLine();
        }

        // h2 = a2 + b2
        // Receba a Base e Altura de um Triângulo Retângulo
        // Calcule a Hipotenusa do Triângulo
        // "A Hipotenusa do Triângulo é [Hipotenusa]"
        static void exercicio05()
        {
            double baseT, altT, hipoT;

			Console.WriteLine("Digite a base do triângulo: ");
            baseT = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Digite a altura do triângulo: ");
			altT = Convert.ToDouble(Console.ReadLine());

            baseT = Math.Pow(baseT, 2);
            altT = Math.Pow(altT, 2);
            hipoT = baseT + altT;
            hipoT = Math.Sqrt(hipoT);

			Console.Write($"A hipotenusa do triângulo é {hipoT}");
			Console.ReadLine();
        }


        // A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%.
        // Escreva um Programa em C# que leia o número de horas trabalhadas em um mês, o salário por hora e escreva o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas.
        // Considere que o mês possua 4 semanas exatas
        static void exercicio06()
        {
            int horasTrabalhadas, horasExtras;
            double salarioHora, salarioHoraExtra, salarioBase, salarioExtra, salarioTotal;

			Console.WriteLine("Digite o número de horas trabalhadas no mês: ");
			horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite o valor do salário por hora: ");
			salarioHora = Convert.ToDouble(Console.ReadLine());

            salarioBase = salarioHora * 160;

            if (horasTrabalhadas > 160)
            {
                horasExtras = horasTrabalhadas - 160;
                salarioHoraExtra = salarioHora * 1.5;
                salarioExtra = salarioHoraExtra * horasExtras;
                salarioTotal = salarioBase + salarioExtra;

				Console.Write($"O valor total do salário é {salarioTotal}");
				Console.ReadLine();
            }
            else
            {
                salarioTotal = salarioBase;

				Console.Write($"O valor total do salário é {salarioTotal}");
				Console.ReadLine();
            }
        }


        // O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do distribuidor e dos impostos (aplicados ao custo de fábrica).
        // Supondo que o percentual do distribuidor seja de 28% e os impostos de 45%, escreva um Programa em C# para ler o custo de fábrica de um carro, calcular e escrever o custo final ao consumidor.
        static void exercicio07()
        {
            double custoFabrica, lucro, impostos, custoFinal, indLucro, indImposto;

            indLucro = 0.28;
            indImposto = 0.45;

			Console.WriteLine("Digite o custo de fábrica do carro: ");
			custoFabrica = Convert.ToDouble(Console.ReadLine());

            lucro = Math.Round(custoFabrica * indLucro, 2);
            impostos = Math.Round(custoFabrica * indImposto, 2);
            custoFinal = custoFabrica + impostos + lucro;
            
            Console.Write($"O custo final do carro é {custoFinal}");
			Console.ReadLine();
        }
    }
}

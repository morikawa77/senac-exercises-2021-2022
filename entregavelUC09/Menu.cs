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

    // Methods:

    public void sair() {
      Environment.Exit(0);
    }

    public void exercicio01() {
      Console.WriteLine("Hello World!");
    }

    public void exercicio02() {
      Console.WriteLine("Digite o seu nome:");
      string nome = Console.ReadLine();

      Console.WriteLine("Digite a sua cidade:");
      string cidade = Console.ReadLine();

      Console.WriteLine("Digite o seu bairro:");
      string bairro = Console.ReadLine();

      Console.WriteLine("A pessoa {0} mora em {1} no bairro {2}", nome, cidade, bairro);
    }

    public void exercicio03() {
      Console.WriteLine("Digite o seu nome:");
      string nome = Console.ReadLine();

      Console.WriteLine("Digite a sua idade:");
      int idade = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("A pessoa {0} tem {1} anos de idade.", nome, Convert.ToString(idade));
    }

    // Receba a Base e Altura de um Retângulo
    // Calcule a Área do Retângulo
    // "A área do Retângulo é [Área]"
    public void exercicio04()
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
    public void exercicio05()
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
    public void exercicio06()
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
    public void exercicio07()
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
    public void exercicio08()
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
    public void exercicio09()
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
      } else {
        salarioTotal = salarioBase;

        Console.Write($"O valor total do salário é {salarioTotal}");
        Console.ReadLine();
      }
    }


    // O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do distribuidor e dos impostos (aplicados ao custo de fábrica).
    // Supondo que o percentual do distribuidor seja de 28% e os impostos de 45%, escreva um Programa em C# para ler o custo de fábrica de um carro, calcular e escrever o custo final ao consumidor.
    public void exercicio10()
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

    // Operadores lógicos
    public void exercicio11() {
      int A=5, B=4, C=3, D=6;

      Console.WriteLine((A > C) && (C <= D));

      Console.WriteLine(((A+B) > 10) || ((A+B) == (C+D)));

      Console.WriteLine((A>=C) && (D >= C));

      Console.WriteLine(!((A-C) > (B-D)));

      Console.WriteLine(!((C+D+A)!=(B+C+D)));
    }

    // Receba um número A e um número B, e escreva a tabuada do número A até o limite definido no número B.
    public void exercicio12() {
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
    public void exercicio13() {
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
    public void exercicio14() {
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
    public void exercicio15() {
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
    public void exercicio16() {
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
    public void exercicio17() {
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
    public void exercicio18() {
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
    public void exercicio19() {
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
    public void exercicio20() {
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
    public void exercicio21() {
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
    public void exercicio22() {
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
    public void exercicio23() {
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

    // Escreva um programa em C# para exibir uma sequência de números na ordem inversa.
    public void exercicio24()
    {
      string sequencia;

      Console.WriteLine("Digite uma sequencia de números:");
      sequencia = Console.ReadLine();

      char[] array = sequencia.ToCharArray();
      Array.Reverse(array);

      Console.WriteLine(array);
    }


    // Escreva um programa C# para encontrar os números perfeitos dentro de um determinado intervalo de número.
    public void exercicio25()
    {
      int inicial, final, value;
      List<int> perfects = new List<int>();

      Console.WriteLine("Digite o primeiro número:");
      inicial = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Digite o último número:");
      final = Convert.ToInt32(Console.ReadLine());

      value = inicial;

      while (value <= final)
      {
        int sum = 0;

        for (int cnt = 1; cnt < value; ++cnt)

          if ((value % cnt) == 0) sum += cnt;

        if (value == sum)
        {
            perfects.Add(value);
        }

        value++;
      }

      Console.Write("Os números perfeitos no intervalo dado é: ");
      perfects.ForEach(item => Console.Write(item + " "));

      Console.WriteLine("");
    }


    // Escreva um programa C# para determinar se um dado número é primo ou não.
    public void exercicio26()
    {
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

    // Uma pessoa só pode votar em eleições brasileiras se ela for maior que 16 anos e for cidadã brasileira.
    // Crie um programa com duas variáveis, int idade, bool brasileira, e faça com que o programa diga se a pessao está apta a votar ou não, de acordo com os dados nas variáveis.
    public void exercicio27()
    {
      int idade;
      bool brasileira;

      Console.WriteLine("Digite sua idade:");
      idade = Convert.ToInt32(Console.ReadLine());

      if (idade <16) {
        Console.WriteLine("Não pode votar.");
      } else {
        Console.WriteLine("Você tem nacionalidade brasileira?");
        Console.WriteLine("V ou F");
        if (Console.ReadLine().ToLower() == "v")
        {
          brasileira = true;
        }
        else
        {
          brasileira = false;
        }

        if(brasileira == true) {
          Console.WriteLine("Pode votar.");
        } else {
          Console.WriteLine("Não pode votar.");
        }
      }
    }


    // Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.
    public void exercicio28()
    {
      for (int i = 1; i * 3 < 101; i++)
      {
        Console.WriteLine(i * 3);
      }
    }

    // Escreva um programa em C# que imprime todos os números que são divisíveis por 3 ou por 4 entre 0 e 30.
    public void exercicio29()
    {
      for (int i = 0; i < 31; i++)
      {
        if ((i % 3 == 0) || (i % 4 == 0))
        {
          Console.WriteLine(i);
        }
      }
    }

    // Crie um programa em C# que imprima os fatoriais de 1 a 10.
    // O fatorial de um número n é n n-1 n-2 ... até n = 1.
    public void exercicio30()
    {
      int fatorial = 1;
      
      for (int n = 1; n <= 10; n++)
      {
        fatorial = fatorial * n;
        Console.WriteLine("O fatorial de "+n+" é (" + (n-1) + "!) * " + (n) + " = " + fatorial);
      }

      Console.WriteLine("");
    }

    //Faça um programa em C# que imprima os primeiros números da série de Fibonacci até passar de 100
    // A série de Fibonacci é a seguinte: 0, 1, 1, 2, 3, 5, 8, 13, 21 etc..
    // Para calculá-la, o primeiro elemento vale 0, o segundo vale 1, daí por diante, o n-ésimo elemento vale o(n-1)-ésimo elemento somado ao(n-2)- ésimo elemento(ex: 8 = 5 + 3).
    public void exercicio31()
    {
      int a = 0, fib = 1;

      while (fib <= 100)
      {
        Console.Write(a + " " + fib + " ");
        a += fib;
        fib += a;
      }

      Console.WriteLine("");

    }

    // Faça um programa que imprima a seguinte tabela, usando for encadeados:
    // 1 
    // 2 4
    // 3 6 9
    // 4 8 12 16
    // n n*2 n*3 .... n* n
    public void exercicio32()
    {
      int linhas;

      Console.Write("Digite o número de linhas: ");
      linhas = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("");
      Console.WriteLine("1");

      for (int i = 2; i <= linhas; i++){
        for (int j = 1; j <= i; j++){
            Console.Write(i * j+" ");
        }
        Console.WriteLine("");
      }

      Console.WriteLine("");
    }

    // Escreva um programa em C# para fazer um padrão como uma pirâmide com um asterisco:
    //     *
    //    * *
    //   * * *
    //  * * * *
    public void exercicio33()
    {
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
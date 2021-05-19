using System;

namespace Lista18052021
{
    class Program
    {
        static void Main(string[] args)
        {

            int A=5, B=4, C=3, D=6;

            Console.WriteLine((A > C) && (C <= D));

            Console.WriteLine(((A+B) > 10) || ((A+B) == (C+D)));

            Console.WriteLine((A>=C) && (D >= C));

            Console.WriteLine(!((A-C) > (B-D)));

            Console.WriteLine(!((C+D+A)!=(B+C+D)));

            Console.ReadKey();
        }
    }
}
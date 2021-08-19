using System;

namespace terceiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        
        
            //crie um programa que receba um numero inteiro e calcule a sua tabuada de 0 a 10

            Console.WriteLine("Digite um numero:" );
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------" );

            Console.WriteLine(num1+ " x 0 = " +0 * num1);
            Console.WriteLine(num1+ " x 1 = " +1 * num1);
            Console.WriteLine(num1+ " x 2 = " +2 * num1);
            Console.WriteLine(num1+ " x 3 = " +3 * num1);
            Console.WriteLine(num1+ " x 4 = " +4 * num1);
            Console.WriteLine(num1+ " x 5 = " +5 * num1);
            Console.WriteLine(num1+ " x 6 = " +6 * num1);
            Console.WriteLine(num1+ " x 7 = " +7 * num1);
            Console.WriteLine(num1+ " x 8 = " +8 * num1);
            Console.WriteLine(num1+ " x 9 = " +9 * num1);
            Console.WriteLine(num1+ " x 10 = " +10 * num1);
            Console.ReadLine();



        
        
        }
    }
}

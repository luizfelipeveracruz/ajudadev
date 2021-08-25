using System;

namespace quarto_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores aritimeticos");

            //Divisão
            Console.WriteLine("Digite a nota da primeira prova:");
            double p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova:");
            double p2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da terceira prova:");
            double p3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do trabalho:");
            double t1 = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");
            
            Console.WriteLine("Resultado:"+(p1 + p2 + p3 + t1)/4);

        }
    }
}

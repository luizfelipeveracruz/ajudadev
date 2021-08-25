using System;

namespace segundo_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA DE DADOS
        
            Console.WriteLine("calculo de dois numeros inteiros");
            Console.WriteLine("digite o primeiro numero: ");
            int valor1 = int.Parse(Console.ReadLine());  //       o int.PARSE é para converter o texto em numero
            Console.WriteLine("digite o segundo numero: ");
            int valor2 = int.Parse(Console.ReadLine());
            
            //PROCESSAMENTO DE DADOS

            int soma = valor1 + valor2;
            int subtracao = valor1 - valor2;
            int multiplicação = valor1 * valor2;

            //SAÍDA DE DADOS

            Console.WriteLine("A soma dos valores é = " +soma );
            Console.WriteLine("A multiplicação dos valores é = " + multiplicação); 
            Console.WriteLine("A subtração dos valores é = " +subtracao );
            
        
            
        }
    }
}

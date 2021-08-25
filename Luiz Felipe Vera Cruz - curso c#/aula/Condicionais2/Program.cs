using System;

namespace Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de dois digitos");
            Console.WriteLine("---------------------------");
            Console.Write("digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("digite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("qual operação deseja fazer?");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            int resposta = int.Parse(Console.ReadLine());

            double resultado = 0;

            //bool - true ou false
            bool validacao = true;
        

            if(resposta == 1){
                resultado = num1 + num2;
            
            }else if(resposta == 2){
                resultado = num1 - num2;
            
            }else if(resposta == 3){                
                resultado = num1 * num2;

            }else if(resposta == 4){    
                resultado = num1 / num2;
            
            }else{
                Console.WriteLine("Opção inválida!");
                validacao = false;
            }
            
            if(validacao == true){
                Console.WriteLine("Object resultado = " +resultado);
            } 
        }
    }
}

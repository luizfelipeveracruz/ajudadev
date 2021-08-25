using System;

namespace Calculadora_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qaul operação lógica deseja fazer (+, -, *, /)?");
            string operacao = Console.ReadLine();
            
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;
            bool validador = true;

            switch(operacao)
            {
                case "+": 
                    resultado = num1 + num2;
                break;
                
                case "-": 
                    resultado = num1 - num2;
                break;

                case "*": 
                    resultado = num1 * num2;
                break;

                case "/": 
                    if(num2 == 0){
                    Console.WriteLine("Impossível dividir por 0!");

                    }else{
                        resultado = num1 / num2;
                    }
                break;
                default:
                    Console.WriteLine("Operação Inválida!");
                    validador = false;
                break;
            }

                if(validador == true){
                    Console.WriteLine("O resultado é = "+resultado);
                }
                
            








        }
    }
}

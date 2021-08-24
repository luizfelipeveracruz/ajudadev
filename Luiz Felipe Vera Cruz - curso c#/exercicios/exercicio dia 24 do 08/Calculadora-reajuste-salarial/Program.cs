using System;

namespace exercicio_dia_24_do_08
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Uma empresa decide dar aumento de 30% aos funcionários cujo salário é
            //  inferior a 500 reais. Escreva um programa que receba o salário de um
            //  funcionário e exiba o valor do salário reajustado ou uma mensagem caso
            //  o funcionário não tenha direito a aumento
            
            Console.Write("Digite o valor do seu salário: " );
            double salario = double.Parse(Console.ReadLine());

            double aumento = 500;
            double fracao = 30.0/100.0;
            double resultado ;
            double salarioAtual;

            if(salario > aumento){
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Reajuste indisponivél para o piso salarial.");
            }else{
                resultado = salario * fracao;
                salarioAtual = resultado + salario;
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Reajuste aplicado! o seu salario atual é de R$"+salarioAtual);

            
            }

        }

    }
}

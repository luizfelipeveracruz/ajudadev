using System;

namespace Cardapio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que leia o número de um pedido de um cliente:
            // Se digitar 1 = Hamburguer 
            // Se digitar 2 = Cheese Salada
            // Se digitar 3 = Cheese burguer
            // Se digitar 4 = Cheese bacon
            // Se digitar qualquer outro valor: "Opção inválida!"

            Console.WriteLine("Lanches");
            Console.WriteLine("----------------");
            
            int numLanche ;
            do
            {
                Console.WriteLine("1 = Hamburguer");
                Console.WriteLine("2 = Cheese Salada");
                Console.WriteLine("3 = Cheese burguer");
                Console.WriteLine("4 = Cheese bacon");
                Console.WriteLine("----------------");
                Console.Write("Digite o número do lanche que deseja: ");
                numLanche = int.Parse(Console.ReadLine());
            
            }while(numLanche < 1 || numLanche > 4);
            // double num1 = double.Parse(Console.ReadLine());

            
            bool validador = true;

            switch(numLanche)
            {
                case 1:
                    Console.WriteLine("Hamburguer");
                break;
                case 2:
                    Console.WriteLine("Cheese Salada");
                break;
                 case 3:
                    Console.WriteLine("Cheese burguer");
                break;
                 case 4:
                    Console.WriteLine("Cheese bacon");
                break;
                default:
                    Console.WriteLine("Opção inválida");
                    validador = false;
                break; 

            }

            

                if(validador == true){
                Console.WriteLine("Lanche escolhido: "+numLanche);
                }
                







        }
    }
}

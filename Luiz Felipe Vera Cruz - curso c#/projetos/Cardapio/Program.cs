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
            Console.WriteLine("1 = Hamburguer");
            Console.WriteLine("2 = Cheese Salada");
            Console.WriteLine("3 = Cheese burguer");
            Console.WriteLine("4 = Cheese bacon");
            Console.WriteLine("----------------");
            Console.Write("Digite o número do lanche que deseja: ");
            int numLanche = int.Parse(Console.ReadLine());
            // double num1 = double.Parse(Console.ReadLine());

            string lanche = "" ;
            bool validador = true;

            switch(numLanche)
            {
                case 1:
                    lanche = "Hamburguer";
                break;
                case 2:
                    lanche = "Cheese Salada";
                break;
                 case 3:
                    lanche = "Cheese burguer";
                break;
                 case 4:
                    lanche = "Cheese bacon";
                break;
                default:
                    Console.WriteLine("Opção inválida");
                    validador = false;
                break; 

            }

            

                if(validador == true){
                Console.WriteLine("Lanche escolhido: "+lanche);
                }
                







        }
    }
}

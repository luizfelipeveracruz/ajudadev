using System;

namespace calculadora_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int contadorMaior = 0;
            int contadormenor = 0;
            int somaIdade = 0;


            do{
                Console.Write("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());

                if(idade >= 18){
                    contadorMaior = contadorMaior++;

                }else{
                    contadormenor = contadormenor++;

                }

                somaIdade = somaIdade + idade;
                contador = contador +1;

            }while (contador < 10);

            Console.WriteLine($"A média de idade de todos é: {somaIdade/contador}");


        }
    }
}

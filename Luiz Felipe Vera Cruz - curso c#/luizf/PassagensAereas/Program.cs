using System;

namespace PassagensAereas
{
    class Program
    {
        static void Main(string[] args)
        {

        //declaraão de variaveis
        string opcao, resposta;
        string [] nomes = new string[5];
        string [] origens = new string[5];
        string [] destinos = new string[5];
        string [] datas = new string[5];
        int contador = 0;
           
            //ENTRADA
            Console.Write("Digite a senha: ");
            string senhaDigitada = Console.ReadLine();
            bool retornoDaFuncao = ValidarSenha(senhaDigitada);

            while (!retornoDaFuncao)
            {
                Console.WriteLine("Senha Inválida");
                Console.Write("Digite novamente a senha: ");
                senhaDigitada = Console.ReadLine();
                retornoDaFuncao = ValidarSenha(senhaDigitada);
            }//fim while
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("  Bem Vindo a Tsukamoto AirLines ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-------Selecione uma opção-------");
            Console.WriteLine("---------------------------------");

            do
            {
            Console.WriteLine("[1] - Cadastrar Passagem");
            Console.WriteLine("[2] - Listar Passagens");
            Console.WriteLine("[3] - Buscar Passageiro");
            Console.WriteLine("[4] - Sair");
            opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    Console.WriteLine("Cadastro de passagens");
                    CadastrarPassagens();
                        break;

                    case "2":
                    Console.WriteLine("Listar Passagens");
                    ListarPassagens();
                        break;

                    case "3":
                    Console.WriteLine("Digite o nome do passageiro");
                    string nome = Console.ReadLine();
                    BuscaPassagem(nome);
                     break;
                    
                     case "4":
                        Console.WriteLine("Obrigado por usar Tsukamoto Air Lines");
                        Console.WriteLine("Volte sempre!");
                        break;

                    default:
                    Console.WriteLine("Opção Inválida");
                        break;
                }//fim Switch
                
            
            }while (opcao != "4");

            //função
            bool ValidarSenha(string senha)
            {
                if (senha == "123456")
                {
                    return true;
                    
                }else
                {
                    return false;
                }
            }//FIM VALIDAR SENHA

            void CadastrarPassagens()
            {

                do
                {
                    if (contador < 5)
                    {
                    Console.WriteLine("Digite o nome do passageiro");
                    nomes[contador] = Console.ReadLine();
                    Console.WriteLine("Digite a origem");
                    origens[contador] = Console.ReadLine();
                    Console.WriteLine("Digite o destino");
                    destinos[contador] = Console.ReadLine();
                    Console.WriteLine("Digite a data da viagem");
                    datas[contador] = Console.ReadLine();

                    Console.WriteLine("Gostaria de cadastrar outra passagem?");
                    resposta = Console.ReadLine();
                    } else {
                        Console.WriteLine("Limite excedido!");
                        break;
                    } //fim do if else
                    
                    contador++;
                } while (resposta == "sim");             
            }//FIM CADASTRO PASSAGENS

            void ListarPassagens()
            {
                Console.WriteLine("Passagens cadastradas: ");
                for (var i = 0; i < contador; i++)
                {
                    Console.WriteLine($"{nomes[i]} data: {datas[i]}");

                }
                
            }//FIM LISTAR PASSAGENS

            void BuscaPassagem(string nome)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (nome == nome[i])    
                    {
                        Console.WriteLine($"Passageiro {nomes[i]} tem a viagem para o dia: {datas[i]}");
                    }
                }
                
            }//FIM PESQUISA DE CADASTROS




        }// FIM MAIN
    }
}

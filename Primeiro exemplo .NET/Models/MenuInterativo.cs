using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro_exemplo_.NET.Models
{
        public class MenuInterativo // cria Classe Calculadora, cheia de Métodos (as operações que ela pode fazer)
        {
                // Construindo um menu interativo
                public bool exibirMenu = true;
                public void Exibir() // método dentro da classe que exibirá as opções do usuário
                {

                        while (exibirMenu)
                        {
                                Console.WriteLine("Digite uma das opções:");
                                Console.WriteLine("1 - Cadastro cliente");
                                Console.WriteLine("2 - Buscar cliente");
                                Console.WriteLine("3 - Apagar cliente");
                                Console.WriteLine("4 - Encerrar");


                                string opcao = Console.ReadLine();
                                ExecutarOpcao(opcao);
                        }
                }

                public void ExecutarOpcao(string opcao)
                {
                        switch (opcao)
                        {
                                case "1":
                                        Console.WriteLine("Cadastro cliente");
                                        break;

                                case "2":
                                        Console.WriteLine("Buscar cliente");
                                        break;

                                case "3":
                                        Console.WriteLine("Apagar cliente");
                                        break;

                                case "4":
                                        Console.WriteLine("Encerrar");
                                        //Environment.Exit(0); // o programa se encerra e, se mais códigos forem implementados após isso, não rodará. Então o               mais corretor é trocar por:
                                        exibirMenu = false; // assim ele torna o while 'false', o que faz com que encerre o while sem encerrar o programa inteiro.
                                        break;

                                default:
                                        Console.WriteLine("Opção inválida.");
                                        break;
                        }
                }
        }
}
 

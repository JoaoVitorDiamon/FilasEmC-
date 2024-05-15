using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilasEmC_
{
    public class Program
    {
        static void Main(string[] args)
        {
            FilaClientes filaDeClientes = new FilaClientes();

            string opcao = "a";

            opcao.ToLower();
            while (opcao != "q")
            {
                Console.WriteLine("1. Cadastrar cliente");
                Console.WriteLine("2. Mostrar fila");
                Console.WriteLine("3. Adicionar Cliente com Prioridade");
                Console.WriteLine("4. Atender cliente");
                Console.WriteLine("Digite  a Letra 'q' para sair.");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o nome do cliente: ");
                        string nome = Console.ReadLine();
                        filaDeClientes.CadastrarClientes(nome);
                        break;
                    case "2":
                        filaDeClientes.MostrarLista();
                        break;
                    case "3":
                        Console.Write("Digite o nome do cliente prioritário: ");
                        nome = Console.ReadLine();
                        filaDeClientes.AdicionarPrioridade(nome);
                        break;
                    case "4":
                        filaDeClientes.AtenderPessoa();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }


    }
    }


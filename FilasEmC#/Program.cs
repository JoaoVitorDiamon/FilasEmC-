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

            while (opcao.ToLower() != "q")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t\t\t\t\t\tSISTEMA DE FILAS\n" +
                    "1. Cadastrar clientes\n" +
                    "2. Mostrar fila\n" +
                    "3. Adicionar Cliente com Prioridade\n" +
                    "4. Atender cliente\nDigite  a Letra 'q' para sair.");


                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        filaDeClientes.CadastrarClientes();
                        break;
                    case "2":
                        filaDeClientes.MostrarLista();
                        break;
                    case "3":
                        filaDeClientes.AdicionarPrioridade();
                        break;
                    case "4":
                        filaDeClientes.AtenderPessoa();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }


    }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilasEmC_
{
    public class FilaClientes
    {
        private Pessoa[] filaClientes;
        private int QuantidadesClientes = 0;
        private int tamanhoDaFila = 10;
        private int NumeroPrioridade = 0;


        public FilaClientes()
        {
            filaClientes = new Pessoa[tamanhoDaFila];
        }

        public void CadastrarClientes()
        {
            Console.WriteLine("Digite o Nome do Seu Cliente:");
            string nome = Console.ReadLine();

            if (QuantidadesClientes < tamanhoDaFila)
            {

            Pessoa pessoa = new Pessoa(nome);
                filaClientes[QuantidadesClientes] = pessoa;
                QuantidadesClientes += 1;
            }
            else
            {
                Console.WriteLine("Fila esta Cheia");
            }
        }

        public void MostrarLista()
        {
            for (int i = 0; i < filaClientes.Length; i++)
            {
                if (filaClientes[i] != null)
                {
                    Console.WriteLine($"\nCliente:{i + 1 }\nNome:{filaClientes[i].nome}");
                    Console.WriteLine("Aperte qualquer tecla pra voltar...");
                     Console.ReadKey();
                }

                

            }
        }


        public void AdicionarPrioridade()
        {
            Console.WriteLine("Digite o Nome do Seu Cliente:");
            string nome = Console.ReadLine();
            if (QuantidadesClientes < tamanhoDaFila)
            {
                Pessoa pessoa = new Pessoa(nome, true);

                for (int i = QuantidadesClientes; i > 0; i--)
                {
                    for(int j = i - 1; j > 0; j--)
                    {

                        var aux = filaClientes[i];
                        filaClientes[i] = filaClientes[j];
                        filaClientes[j] = aux;
                    }
                }
                if (filaClientes[NumeroPrioridade].prioridade == true)
                {
                filaClientes[NumeroPrioridade] = pessoa;
                NumeroPrioridade+= 1;
                }

                
                Console.Clear();
                Console.WriteLine($"Peessoa {nome} incluído como priordade.");
                Console.WriteLine("Aperte qualquer tecla pra voltar...");
                Console.ReadKey();
                Console.Clear();
                QuantidadesClientes++;
            }
        }


        public void AtenderPessoa()
        {
  
        
                if (QuantidadesClientes > 0)
                {
                    Pessoa pessoaAtendida = filaClientes[0];
                    for (int i = 0; i < QuantidadesClientes - 1; i++)
                    {
                        filaClientes[i] = filaClientes[i + 1];
                    }
                    Console.WriteLine($"Cliente {pessoaAtendida.nome} atendido.");
                }
                else
                {
                    Console.WriteLine("Não há clientes na fila.");
                }
                Console.WriteLine("Aperte qualquer tecla pra voltar...");
                Console.ReadKey();
                Console.Clear();
            }

  
        }

    }


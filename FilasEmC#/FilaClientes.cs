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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Digite o Nome do Seu Cliente:");
            string nome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine($"O Cliente {nome} foi inserido com Sucesso");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Aperte qualquer tecla pra voltar...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            if (QuantidadesClientes < tamanhoDaFila)
            {

            Pessoa pessoa = new Pessoa(nome);
                filaClientes[QuantidadesClientes] = pessoa;
                QuantidadesClientes += 1;
            Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Fila esta Cheia");
                Console.ForegroundColor = ConsoleColor.Red;

            }
        }

        public void MostrarLista()
        {
            if(QuantidadesClientes > 0)
            {

            for (int i = 0; i < filaClientes.Length; i++)
            {
                if (filaClientes[i] != null)
                {
                    string mensagemDaPrioridade = filaClientes[i].prioridade == false ? "Nao Prioritario" : "Prioritario";

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nCliente:{i + 1}\nNome:{filaClientes[i].nome}\nPrioridade:{mensagemDaPrioridade}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Aperte qualquer tecla pra voltar...");
                    Console.ForegroundColor = ConsoleColor.White;
                     Console.ReadKey();
                    Console.Clear();
                }

                

            }
            } else
                {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fila está Vazia.");
                Console.WriteLine("Aperte qualquer tecla pra voltar...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
        }


        public void AdicionarPrioridade()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();
            Console.WriteLine("Digite o Nome do Seu Cliente:");
            string nome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine($"O Cliente {nome} prioritario foi inserido com sucesso");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Aperte qualquer tecla pra voltar...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            if (QuantidadesClientes < tamanhoDaFila)
            {
                Pessoa pessoaPrioridade = new Pessoa(nome, true);

                for (int i = QuantidadesClientes - 1; i >= NumeroPrioridade; i--)
                {

                    filaClientes[i + 1] = filaClientes[i];
                }

                filaClientes[NumeroPrioridade] = pessoaPrioridade;
                QuantidadesClientes++;
                NumeroPrioridade++;
            }
            else
            {
                
                Console.WriteLine("Fila está cheia.");
                Console.WriteLine("Aperte qualquer tecla pra voltar...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void AtenderPessoa()
        {
            if (QuantidadesClientes > 0)
            {
                Pessoa pessoaAtendida = filaClientes[0];

                for (int i = 1; i < QuantidadesClientes; i++)
                {
                    filaClientes[i - 1] = filaClientes[i];
                }

                filaClientes[QuantidadesClientes - 1] = null;

                QuantidadesClientes--;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine($"Cliente {pessoaAtendida.nome} atendido.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não há clientes na fila.");
            }

            Console.WriteLine("Aperte qualquer tecla para voltar...");
            Console.ReadKey();
            Console.Clear();
        }







    }

}


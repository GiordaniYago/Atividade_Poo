using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            List<Cliente> clienteList = new List<Cliente>();
            List<Cliente> novosCLientes = new List<Cliente>();
            Console.WriteLine("Área do Cliente");
            do
            {
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Editar");
                Console.WriteLine("3 - Listar");
                Console.WriteLine("4 - Excluir");
                Console.WriteLine("5 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                switch (opcao)
                {
                    case 1:
                        int proximoId = 0;
                        if (clienteList.Count > 0)
                        {
                            int ultimoCliente = clienteList.Count();
                            proximoId = clienteList[ultimoCliente].Id + 1;
                        }
                        novosCLientes = Cadastro(proximoId);
                        clienteList.AddRange(novosCLientes);
                        break;

                    case 2:
                        Editar(clienteList);
                        break;

                    case 3:
                        Listar(clienteList);
                        break;

                    case 4:
                        Excluir(clienteList);
                        break;


                    default:
                        Console.WriteLine("opção inválida");
                        break;
                }
            } while (opcao != 5);
            Console.ReadLine();

        }

        static List<Cliente> Cadastro(int posicaoId)
        {
            List<Cliente> novosCLientes = new List<Cliente>();
            bool verificacao = true;
            string novoCadastro = "N";
            Console.WriteLine("CADASTRO DE CLIENTE");
            do
            {
                Cliente cliente = new Cliente();
                cliente.Id = posicaoId;
                Console.WriteLine("Por favor, nos informe os seguintes dados:");
                Console.Write("Nome: ");
                cliente.Nome = Console.ReadLine();
                Console.Write("Endereço: ");
                cliente.Endereco = Console.ReadLine();
                Console.Write("Data de nascimento: ");
                cliente.DataNascimento = Console.ReadLine();

                novosCLientes.Add(cliente);
                Console.Write("Deseja realizar um novo cadastro? S/N ");
                novoCadastro = Console.ReadLine();
                if (novoCadastro.ToUpper() != "S") { verificacao = false; }
                Console.WriteLine("\n");

                posicaoId++;
            } while (verificacao);

            return novosCLientes;
        }

        static void Editar(List<Cliente> clienteList)
        {
            var cliente = new Cliente();
            Console.WriteLine("digite o nome completo do cliente que gostaria de editar");
            cliente.Nome = Console.ReadLine();

            cliente = clienteList.Find(x => x.Nome == cliente.Nome);
            if (cliente != null)
            {
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Endereço: {cliente.Endereco}");
                Console.WriteLine($"Data de nascimento: {cliente.DataNascimento}");
                Console.WriteLine("\n");

                Console.WriteLine("NOVOS DADOS");
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Endereço: ");
                string Endereco = Console.ReadLine();
                Console.Write("Data de nascimento: ");
                string DataNascimento = Console.ReadLine();

                Console.WriteLine("Deseja alterar os dados do cliente? S/N");
                var aprovar = Console.ReadLine();
                Console.WriteLine("\n");

                if (aprovar.ToUpper() == "S")
                {
                    cliente.Nome = Nome;
                    cliente.Endereco = Endereco;
                    cliente.DataNascimento = DataNascimento;

                    Console.WriteLine("cliente alterado com sucesso");
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("cliente não encontrado!!");
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }

        static void Listar(List<Cliente> clienteList)
        {
            int posicao = 1;
            foreach (Cliente cliente in clienteList)
            {
                Console.WriteLine($"{posicao} - {cliente.Nome}");
                posicao++;
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }

        static void Excluir(List<Cliente> clienteList)
        {
            var cliente = new Cliente();
            Console.WriteLine("digite o nome completo do cliente que gostaria de excluir");
            cliente.Nome = Console.ReadLine();

            cliente = clienteList.Find(x => x.Nome == cliente.Nome);
            if (cliente != null)
            {
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Endereço: {cliente.Endereco}");
                Console.WriteLine($"Data de nascimento: {cliente.DataNascimento}");
                Console.WriteLine("\n");

                Console.WriteLine("Deseja excluir esse cliente? S/N");
                var aprovar = Console.ReadLine();
                Console.WriteLine("\n");

                if (aprovar.ToUpper() == "S")
                {
                    clienteList.Remove(cliente);

                    Console.WriteLine("cliente excluido com sucesso");
                    Console.WriteLine("\n");

                }
            }
            else
            {
                Console.WriteLine("cliente não encontrado!!");
                Console.WriteLine("\n");
            }
        }
    }
}

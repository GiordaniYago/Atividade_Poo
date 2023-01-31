using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2_POO
{
    internal class Cliente
    {
        public int Id;
        public string Nome;
        public string Ende;
        public string DataNasci;


        public Cliente(int id, string nome, string ende, string dataNasci)
        {
            Id = id;
            Nome = nome;
            Ende = ende;
            DataNasci = dataNasci;

        }

        public Cliente()
        {

        }

        /*public void Menu()
        {
            int opcao = 0;

            Console.WriteLine("  Por favor, selecione uma opção!");
            Console.WriteLine("-----------------");
            Console.WriteLine("| 1- Criar      |");
            Console.WriteLine("| 2- Editar     |");
            Console.WriteLine("| 3- Listar     |");
            Console.WriteLine("| 4- Excluir    |");
            Console.WriteLine("-----------------");

            switch (opcao)
            {
                case 1:
                    this.Criar();
                    break;
                //case 2:
                //    this.Editar();
                //    break;
                //case 3:
                //    this.Listar();
                //    break;
                //case 4:
                //    this.Excluir();
                //    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }*/

        public void Criar()
        {

            Console.Write("Por favor, nos informe os seguintes dados:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Endereço: ");
            string ende = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            string dataNasci = Console.ReadLine();

            this.Nome = nome;
            this.Ende = ende;
            this.DataNasci = dataNasci;

        }

        public void Editar()
        {
            Console.Write("Por favor, digite qual dado deseja ediar: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "nome":
                    Console.Write("Digite o novo nome: ");
                    string nome = Console.ReadLine();
                    this.Nome = nome;
                    break;
                case "endereço":
                    Console.Write("Digite o novo endereço: ");
                    string ende = Console.ReadLine();
                    this.Ende = ende;
                    break;
                case "data de nascimento":
                    Console.Write("Digite a nova data de nascimento: ");
                    string dataNasci = Console.ReadLine();
                    this.DataNasci = dataNasci;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }


        public void Listar()
        {
            Console.WriteLine("Dados do cliente: " + this.Nome + ", " + this.Ende + ", " + this.DataNasci);
        }

        public void Excluir()
        {
            Console.Write("Por favor, digite qual dado deseja excluir: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "nome":
                    this.Nome = "";
                    break;
                case "endereço":
                    this.Ende = "";
                    break;
                case "data de nascimento":
                    this.DataNasci = "";
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

    }
}

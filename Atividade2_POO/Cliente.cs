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

        //public Cliente(int id, string nome, string ende, string dataNasci)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Ende = ende;
        //    DataNasci = dataNasci;
        //}

        public void Menu()
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
        }

        public string Criar()
        {
            Cliente c1 = new Cliente();

            Console.WriteLine("Por favor, nos informe os seguintes dados:");
            Console.WriteLine("Nome: ");
            c1.Nome = Console.ReadLine();
            Console.WriteLine("Endereço: ");
            c1.Ende = Console.ReadLine();
            Console.WriteLine("Data de nascimento: ");
            c1.DataNasci = Console.ReadLine();

            

            if (c1 != null)
            {
                return c1;
            }
            else
            {
                
            }
        }

        //public bool Editar()
        //{

        //}

        //public List<Cliente> Listar()
        //{

        //}

        //public bool Excluir()
        //{

        //}
        
    }
}

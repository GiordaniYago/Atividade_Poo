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
            Cliente c1 = new Cliente(1, "Yago", "Rua", "11/04/2000");
            

            
            c1.Listar();
            c1.Editar();
            c1.Listar();

            c1.Excluir();
            c1.Listar();

            //Colocar dentro de um método:
            //Console.WriteLine("Olá! Por favor, selecione uma opção!");
            //Console.WriteLine("-----------------");
            //Console.WriteLine("| 1- Cliente    |");
            //Console.WriteLine("| 2- Produto    |");
            //Console.WriteLine("-----------------");
            //int opcao = int.Parse(Console.ReadLine());

            //switch (opcao)
            //{
            //    case 1:
            //        Cliente.Menu();
            //        break;
            //    //case 2:
            //    //    break;
            //    //case 3:
            //    //    break;
            //    //case 4:
            //    //    break;
            //    default:
            //        Console.WriteLine("Ooção inválida!");
            //        break;
            //}

            //List<Cliente> lista = new List<Cliente>();
            

            Console.ReadLine();
            
        }
    }
}

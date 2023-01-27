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
            
            //Colocar dentro de um método:
            Console.WriteLine("Olá! Por favor, selecione uma opção!");
            Console.WriteLine("-----------------");
            Console.WriteLine("| 1- Cliente    |");
            Console.WriteLine("| 2- Produto    |");
            Console.WriteLine("-----------------");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Cliente menu = new Cliente();
                    Console.WriteLine(menu.Menu());
                    break;
                //case 2:
                //    break;
                //case 3:
                //    break;
                //case 4:
                //    break;
                default:
                    Console.WriteLine("Ooção inválida!");
                    break;
            }

            Console.ReadLine();
            
        }
    }
}

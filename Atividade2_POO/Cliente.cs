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
        public string Endereco;
        public string DataNascimento;

        public Cliente()
        {

        }

        List<Cliente> listCli = new List<Cliente>();

        public void Excluir()
        {
            Console.Write("Informe o cliente que deseja excluir: ");
            this.Nome = Console.ReadLine();

            //listCli.Remove(this.Nome);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_2802
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = string.Empty;

            Pessoa p = new Pessoa();


            Console.WriteLine("Digite seu nome");
            p.Nome = Console.ReadLine(); 
            Console.WriteLine("Ola " + p.Nome);




            Console.ReadKey();
        }
    }
}

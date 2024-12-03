using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome1, Nome2;
            int Idade1, Idade2;


            Console.WriteLine("Digite o nome da PRIMEIRA pessoa: ");
            Nome1 = Console.ReadLine();
            Console.WriteLine("Digite a idade da PRIMEIRA pessoa: ");
            Idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da SEGUNDA pessoa: ");
            Nome2 = Console.ReadLine();
            Console.WriteLine("Digite a idade da SEGUNDA pessoa: ");
            Idade2 = int.Parse(Console.ReadLine());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;
            string nome1, nome2;
            double media;

            Console.WriteLine("INSIRA OS DADOS DO PRIMEIRO USUARIO");
            Console.WriteLine();
            Console.Write("NOME: "); nome1 = Console.ReadLine();
            Console.Write("IDADE: "); idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("INSIRA OS DADOS DO SEGUNDO USUARIO");
            Console.WriteLine();
            Console.Write("NOME: "); nome2 = Console.ReadLine();
            Console.Write("IDADE: "); idade2 = int.Parse(Console.ReadLine());

            media = (idade1 + idade2) / 2;

            Console.WriteLine("A idade media de "+nome1+" e "+ nome2 +" e de  " + media);
        }
    }
}

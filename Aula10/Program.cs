using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            char cont;
            Console.WriteLine();
            Console.WriteLine("Digite 'N' para sair !");
            Console.WriteLine();
            

            while (true)
            {
                Console.WriteLine("Digite dois numeros: ");
                Console.WriteLine();
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (n1 > n2 )
                {
                    Console.WriteLine("DECRESCENTE !");
                }
                else if(n2 > n1)
                {
                    Console.WriteLine("CRESCENTE !");
                }
                else
                {
                    Console.WriteLine("OS NUMEROS DIGITADOS SÃO IGUAIS");
                }
                Console.WriteLine();
                Console.WriteLine("Deseja continuar? ");
                cont = char.Parse(Console.ReadLine());
                if(cont == 'S')
                {
                    continue;
                }
                else
                {
                    break;
                }
                
            }
        }
    }
}

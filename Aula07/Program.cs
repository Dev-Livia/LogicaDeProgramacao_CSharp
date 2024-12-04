using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int n;

            Console.WriteLine("Quantos nunmeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double [n];
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);

            }
            Console.WriteLine();
            Console.WriteLine("Numeros digitados: ");
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, MENOR;
            Console.Write("Primeiro numero > ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Segundo numero > ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Terceiro numero > ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (A < B && A < C)
            {
                MENOR = A;
                Console.WriteLine(" O menor numero e " + A);
            }
            else if (B < A && B < C)
            {
                MENOR = B;
                Console.WriteLine(" O menor numero e " + B);
            }
            else if (C < A && C < B)
            {
                MENOR = C;
                Console.WriteLine("O menor numero e " + C);
            }
            else if (A < C && A < B)
            {
                MENOR = A;
                Console.WriteLine(" O menor numero e " + A);
            }
            else if(B < C && B < A)
            {
                MENOR= B;
                Console.WriteLine("O menor numero e " + A);
            }
            else if(C < A && C < B)
            {
                MENOR = C;
                Console.WriteLine("O menor numero e " + C);
            }
            else
            {
                Console.WriteLine("Os numeros digitado");
            }


        }
    }
}

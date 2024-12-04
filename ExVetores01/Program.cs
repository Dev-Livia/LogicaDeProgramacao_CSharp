using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExVetores01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que:
            //Leia 10 números inteiros e os armazene em um vetor.
            //Calcule e exiba a soma de todos os números do vetor.
            int[] numeros = new int[10];

            // Passo 2: Ler os números do usuário
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Passo 3: Calcular a soma
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            // Passo 4: Mostrar o resultado
            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}

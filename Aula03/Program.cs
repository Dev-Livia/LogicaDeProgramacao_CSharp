﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;
            string nome;
            char sexo;
            int idade;
            double salario;

            nome = "Lívia Nicole";
            sexo = 'F';
            idade = 20;
            salario = 500000.99;

            Console.WriteLine("A Patroa " + nome + " recebe " + salario.ToString("F2",CI) + " Semanais e tem "+ idade + " anos");
        }
    }
}

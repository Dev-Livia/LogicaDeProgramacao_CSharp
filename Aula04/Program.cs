using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            double b1, b2, h, area;
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;

            area = (b1 + b2) / 2.0 * h;
            Console.WriteLine(area.ToString("F2", CI));
        }
    }
}

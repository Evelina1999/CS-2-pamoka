using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apskritimo_plotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivesk apskritimo spinduli");
            decimal apskritimoSpindulys = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Apskritimo ilgis: {(apskritimoSpindulys * 2) * Convert.ToDecimal(Math.PI)}");

            Console.ReadLine();
        }
    }
}

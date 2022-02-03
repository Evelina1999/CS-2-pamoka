using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eilute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekstas;
            Console.WriteLine("Ivesk teksto eilute:");
            tekstas = Console.ReadLine();
            Console.WriteLine((tekstas.Length > 0));

            Console.ReadLine();
        }
    }
}

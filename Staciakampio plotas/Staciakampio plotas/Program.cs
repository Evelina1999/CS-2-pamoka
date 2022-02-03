using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staciakampio_plotas
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            int ilgis;
            int plotis;

            Console.WriteLine("Iveskite staciakampio ilgi");
            ilgis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite staciakampio ploti");
            plotis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Plotas: {ilgis * plotis}"); 

            Console.ReadLine();
        }
    }
}

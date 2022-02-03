using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staciakampio_krastine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite staciakampio krastines x ilgi");
            decimal x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("iveskite staciakampio krastines y ilgi");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine((x * y) / (2 * 3));

            Console.ReadLine();


        }
    }
}

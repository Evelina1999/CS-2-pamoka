using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Didziosios_raides
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda");
            string vardas = Console.ReadLine().ToUpper();
            
            Console.WriteLine("Iveskite pavarde");
            string pavarde = Console.ReadLine().ToUpper();
            

            Console.WriteLine($"{vardas}_{pavarde}" );
            Console.ReadLine();

            

            
        }
    }
}

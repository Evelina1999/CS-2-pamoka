using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vardas_pavarde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vardas, pavarde;

            Console.WriteLine("Iveskite varda:");
            vardas = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Iveskite pavarde:");
            pavarde = Convert.ToString(Console.ReadLine());


            Console.WriteLine($"{vardas} {pavarde}"); 
            Console.ReadLine();

        }
    }
}

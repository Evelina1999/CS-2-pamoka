using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaicius
{
    internal class Program
    {
        static void Main(string[] args)
        {   int skaicius;  
            Console.WriteLine("Iveskite skaiciu:");
            skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}{0}", skaicius);
            Console.ReadLine(); 

        }
    }
}

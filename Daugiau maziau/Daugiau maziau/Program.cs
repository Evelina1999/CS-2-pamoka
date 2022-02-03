using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daugiau_maziau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skaicius;

            Console.WriteLine("Ivesk skaiciu:");
            skaicius = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine((skaicius > 0)); 

            Console.ReadLine();


        }
    }
}

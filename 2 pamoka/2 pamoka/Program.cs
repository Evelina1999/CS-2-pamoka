using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pamoka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivesk skaiciu 1");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivesk skaiciu 2");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("skaiciu suma:");
            Console.WriteLine(skaicius1 + skaicius2);
            Console.WriteLine("skaiciu skirtumas:");
            Console.WriteLine(skaicius1 - skaicius2);
            Console.WriteLine("skaiciu sandauga:");
            Console.WriteLine(skaicius1 * skaicius2);
            Console.WriteLine("skaiciu dalyba:");
            Console.WriteLine(skaicius1 / skaicius2);

            Console.ReadLine(); 

        }
    }
}

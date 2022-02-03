using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekundes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivesk skaiciu (sekundes)");
            int sekundes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Valandu: {sekundes / 3600}");
            Console.WriteLine($"Minuciu: {sekundes / 60}");
            Console.WriteLine($"SEkundziu: {sekundes}");

            Console.ReadLine(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbuotojo_uzmokestis
{
    internal class Program
    {
        static void Main(string[] args)

        {  
            
            
            

            Console.WriteLine("Ivesti darbuotojo ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivesti isdirbtas valandas:");
            decimal valandos = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ivesti valandini:");
            decimal valandinis = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Darbuotojo alga: {valandos * valandinis} ");


            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciu_sulyginimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skaiciusA;
            int skaiciusB;

            Console.WriteLine("Iveskite skaiciu A");
            skaiciusA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu B");
            skaiciusB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((skaiciusA < skaiciusB));

            Console.ReadLine();

 
        }
    }
}

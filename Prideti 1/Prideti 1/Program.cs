using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prideti_1
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

            //skaiciusA++;
            //skaiciusB--;

            Console.WriteLine((skaiciusA++));
            Console.WriteLine((skaiciusB--)); 

            Console.ReadLine();
        }
    }
}

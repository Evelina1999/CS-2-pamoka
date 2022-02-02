using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 2;

            Console.WriteLine($"{A},{B}");

            (A, B) = (B, A);

            Console.WriteLine("{0}, {1}",A,B);

            Console.ReadLine(); 


        }
}
}

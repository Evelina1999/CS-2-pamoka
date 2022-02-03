using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kintamasis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 5; 
            int B = 8;

            (A, B) = (B, A);

            Console.WriteLine($"A, {A}" );
            Console.WriteLine($"B, {B}" );

            Console.ReadLine();

        }
    }
}

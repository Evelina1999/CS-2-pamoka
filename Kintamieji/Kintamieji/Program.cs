using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 15;
            int C;

            Console.WriteLine($"A = {A} \nB = {B}");

            C = A;
            A = B;
            B = C;

            Console.WriteLine($"A = {A} \nB = {B}");


            Console.ReadLine();




        }
    }
}

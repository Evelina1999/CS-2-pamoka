using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mokykla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mokyklosPavadinimas;
            string kursoPavadinimas;
            int studentuSkaicius;
            Console.WriteLine(DateTime.Now);


            Console.WriteLine("Iveskite mokyklos pavadinima:");
            mokyklosPavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite kurso pavadinima:");
            kursoPavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskkite studentu skaiciu:");
            studentuSkaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(
                "Mokyklos pavadinimas: {0}\n" +
                "Kurso pavadinimas: {1}\n" +
                "Studentu skaicius: {2}",
                mokyklosPavadinimas,
                kursoPavadinimas,
                studentuSkaicius);
            

            Console.WriteLine(DateTime.Now);

            Console.ReadLine(); 
        }
    }
}

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
            //string mokyklosPavadinimas;
            //string kursoPavadinimas;
            //int studentuSkaicius;
            //Console.WriteLine(DateTime.Now);


            //Console.WriteLine("Iveskite mokyklos pavadinima:");
            //mokyklosPavadinimas = Console.ReadLine();
            //Console.WriteLine("Iveskite kurso pavadinima:");
            //kursoPavadinimas = Console.ReadLine();
            //Console.WriteLine("Iveskkite studentu skaiciu:");
            //studentuSkaicius = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(
            //    "Mokyklos pavadinimas: {0}\n" +
            //    "Kurso pavadinimas: {1}\n" +
            //    "Studentu skaicius: {2}",
            //    mokyklosPavadinimas,
            //    kursoPavadinimas,
            //    studentuSkaicius);
            

            //Console.WriteLine(DateTime.Now);

            //Console.ReadLine();

            string mokyklosPavadinimas;
            string kursoPabadinimas;
            int studentuSkaicius;
            DateTime kursoPradziosData = new DateTime(2019, 12, 10);
            DateTime kursoPabaigosData = new DateTime(2020, 2, 25);


            double dienuSkirtumas = (kursoPabaigosData - kursoPradziosData).TotalDays;
            double savaiciuSkaicius = dienuSkirtumas / 7;
            double dienuSkaiciusBeSavaitgaliu = savaiciuSkaicius * 4;

            Console.WriteLine("Iveskite mokyklos pavadinima");
            mokyklosPavadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite kursopavadinima");
            kursoPabadinimas = Console.ReadLine();
            Console.WriteLine("Iveskite studentu skaiciu");
            studentuSkaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mokyklos pavadinimas: " + mokyklosPavadinimas);
            Console.WriteLine("Kurso pavadinimas: " + kursoPabadinimas);
            Console.WriteLine("Stdentu skaicius: " + studentuSkaicius);
            Console.WriteLine("Siandienos data: " + DateTime.Now.ToString());
            Console.WriteLine("Kurso pradzios data: " + kursoPradziosData);
            Console.WriteLine("Kurso pabaigos data: " + kursoPabaigosData);
            Console.WriteLine("Dienu skirtumas tarp kuso pradzios ir pabaigos: " + dienuSkirtumas);
            Console.WriteLine("Savaiciu skaicius: {0}", savaiciuSkaicius);
            Console.WriteLine($"Darbo dienu skaicius: {dienuSkaiciusBeSavaitgaliu}");
            Console.ReadLine();



        }
    }
}

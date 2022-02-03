using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miestas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suvesk miesto pavadinima:");
            string miestoPavadinimas = Console.ReadLine();
            Console.WriteLine("Suvesk gatves pavadinima:");
            string gatvesPavadinimas = Console.ReadLine();
            Console.WriteLine("Suvesk namo nr:");
            int namoNr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suvesk pastatymo metus:");
            DateTime pastatymoMetai = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Suvesk statymo pradzios metus:");
            DateTime statymoPradziosMetai = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"Miesto pavadinimas: {miestoPavadinimas}\n" +
                $"Gatves pavadinimas: {gatvesPavadinimas}\n" +
                $"Namo numeris: {namoNr}\n" +
                $"Namo pastatymo metai (pvz. 2022/02/03): {pastatymoMetai}\n" +
                $"Namo statymo pradzia: {statymoPradziosMetai}\n" +
                $"Nama state {(pastatymoMetai - statymoPradziosMetai).TotalDays / 365} metu");

            Console.ReadLine(); 
                



        }
    }
}

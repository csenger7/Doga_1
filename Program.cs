using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem, adja meg a diák pontszámát (0-100): ");
            int pontszam = int.Parse(Console.ReadLine());

            if (pontszam < 0 || pontszam > 100)
            {
                Console.WriteLine("Érvénytelen pontszám");
            }
            else if (pontszam < 50)
            {
                Console.WriteLine("Elégtelen");
            }
            else if (pontszam < 60)
            {
                Console.WriteLine("Elégséges");
            }
            else if (pontszam < 80)
            {
                Console.WriteLine("Közepes");
            }
            else if (pontszam < 90)
            {
                Console.WriteLine("Jó");
            }
            else
            {
                Console.WriteLine("Jeles");
            }
        }
    }
}

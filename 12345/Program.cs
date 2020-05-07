using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Konto> bank = new List<Konto>();
            bank.Add(new Konto("Zuzia", 500));
            bank.Add(new Konto("Basia", 600));
            bank.Add(new Konto("Czesia", 700));
            bank.Add(new KontoFirmowe("Daria", 1500));
            bank.Add(new KontoFirmowe("Ela", 2500));
            bank.Add(new KontoFirmowe("Fiona", 3500));

            foreach (Konto konto in bank)
            {
                Console.WriteLine(konto);
            }

            foreach(Konto konto in bank)
            {
                konto.Wyplata(100);
            }

            foreach (Konto konto in bank)
            {
                Console.WriteLine(konto);
            }

            List<Konto> bankPostortowane = new List<Konto>();

            bankPostortowane = bank.OrderBy(konto => konto.Wlasciciel).ToList();

            foreach (Konto konto in bankPostortowane)
            {
                Console.WriteLine(konto);
            }

            bankPostortowane.Reverse();

            foreach (Konto konto in bankPostortowane)
            {
                Console.WriteLine(konto);
            }

            Console.ReadKey();
            
        }
    }
}

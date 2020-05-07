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

            #region Testy do kont

            
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
            #endregion

            #region testy do RORa

            Console.WriteLine("Ile wpłacasz?");
            double.TryParse(Console.ReadLine(), out double wplata);
            ROR ror = new ROR();
            ror.Wplata(wplata);
            Console.WriteLine($"Wartość salda wynosi {ror.Saldo}");

            #endregion




            Console.ReadKey();
            
        }
    }
}

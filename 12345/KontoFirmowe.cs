using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    class KontoFirmowe : Konto
    {
        public KontoFirmowe(string wlasciciel, int saldo) : base(wlasciciel, saldo) {

        }

        public override string ToString()
        {
            return $"Konto firmowe, właściciel: {this.Wlasciciel}, saldo: {this.Saldo}.";
        }

        public override void Wyplata(int wyplata)
        {
            base.Wyplata(wyplata);
            this.Saldo -= 10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    class Konto
    {
        private int saldo;

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        private string wlasciciel;

        public string Wlasciciel
        {
            get { return wlasciciel; }
            set { wlasciciel = value; }
        }

        public Konto(string wlasciciel, int saldo)
        {
            this.saldo = saldo;
            this.wlasciciel = wlasciciel;
        }

        public override string ToString()
        {
            return $"Konto: właściciel: {this.wlasciciel}, saldo: {this.saldo}.";
        }

        public virtual void Wyplata(int wyplata) {
            this.saldo -= wyplata;
        }
    }
}

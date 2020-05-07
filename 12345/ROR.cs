using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    class ROR : IOperacje
    {
        private double saldo=0;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Wplata(double wplata) {
            this.Saldo += wplata;
        }

        public void Odsetki() {
            if (saldo < 0) {
                this.saldo -= 10;
            }

            if (saldo > 0) {
                this.saldo += 5;
            }
        }
    }
}

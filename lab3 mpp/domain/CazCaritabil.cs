using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_mpp.domain
{
    class CazCaritabil : Entity<long>
    {

        public int SumaAdunata { get; set; }
        public String Nume;
        public Dictionary<Donator, int> Donatori;
        public long IDCaz { get; set; }
        public CazCaritabil()
        {
            SumaAdunata = 0;
            Donatori = new Dictionary<Donator, int>();
        }

        public void AdaugaDonatie(int Suma)
        {
            this.SumaAdunata += Suma;
        }

    }
}

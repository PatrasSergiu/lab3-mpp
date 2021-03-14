using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_mpp.domain
{
    class Donator : Entity<long>
    {

        public long IDDonator { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public Adresa AdresaDonator { get; set; }

        public override string ToString()
        {
            return Nume + " " + Prenume + ", " + AdresaDonator.ToString();
        }

        public Donator(string Nume, string Prenume, Adresa AdresaDonator)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.AdresaDonator = AdresaDonator;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_mpp.domain
{
    class Adresa
    {
        public Adresa(string Strada, int Numar, int Apartament, string CodPostal)
        {
            this.Strada = Strada;
            this.CodPostal = CodPostal;
            this.Numar = Numar;
            this.Apartament = Apartament;
        }

        public string Strada { get; set; }
        public string CodPostal { get; set; }
        public int Numar { get; set; }
        public int Apartament { get; set; }

        public override string ToString()
        {
            return "Strada " + Strada + " Nr. " + Numar.ToString() + " Apartament " + Apartament.ToString();
        }


    }
}

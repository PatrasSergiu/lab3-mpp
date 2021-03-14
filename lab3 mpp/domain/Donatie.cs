using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_mpp.domain
{
    class Donatie : Entity<long>
    {

        public long IDDonatie { get; set; }
        public Donator Don { get; set; }
        public int Suma { get; set; }

        public Donatie(Donator Don, int Suma)
        {
            this.Don = Don;
            this.Suma = Suma;
        }
    }
}

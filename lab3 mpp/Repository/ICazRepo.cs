using lab3_mpp.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_mpp.Repository
{
    interface ICazRepo: IRepository<long, CazCaritabil>
    {

        IEnumerable<Donator> FindAllDonatori();       

    }
}

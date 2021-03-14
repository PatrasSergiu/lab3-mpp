using lab3_mpp.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_mpp
{
    interface IRepository<ID, E> where E : Entity<ID>
    {
        E FindOne(ID id);
        IEnumerable<E> FindAll();
        E Save(E entity);
        E Delete(ID id);
        E Update(E entity);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_mpp.domain.validators
{
    interface Validator<E>
    {
        void Validate(E e);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW_day_17
{
    public class IBAN
    {
        public CreditIban CreditIban(double value)
        {
            return new CreditIban(value);
        }

        public DebitIban DebitIban(double value)
        {
            return new DebitIban(value);
        }
    }
}
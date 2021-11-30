using System;
using System.Collections.Generic;
using System.Text;

namespace HW_day_17
{
    public class CreditIban : IBAN
    {
        private double _limite = 500;
        public double CreditBalance { get; private set; }
        public CreditIban(double value)
        {
            CreditBalance = value;
        }
        public void GetMoney(double value)
        {
            if (CreditBalance - value + _limite < 0)
            {
                throw new ExceedLimitException("You Exceed the Limit");
            }
            else
            {
                CreditBalance = CreditBalance - value;
            }

        }
        public void Deposit(double value)
        {
            CreditBalance = CreditBalance + value;
        }
    }
}
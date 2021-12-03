using System;
using System.Collections.Generic;
using System.Text;

namespace HW_day_17
{
    public class DebitIban : IBAN
    {
        public double DebitBalance { get; private set; }
        public DebitIban(double value)
        {
            DebitBalance = value;
        }
        public void GetMoney(double value)
        {
            if (DebitBalance - value < 0)
            {
                throw new NotEnoughBalanceException("Not enough balance");
            }
            else
            {
                DebitBalance = DebitBalance - value;
            }

        }
        public void Deposit(double value)
        {
            DebitBalance = DebitBalance + value;
        }
    }
}
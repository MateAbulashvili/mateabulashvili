using System;
using System.Collections.Generic;
using System.Text;

namespace HW_day_17
{
    public class NotEnoughBalanceException : Exception
    {
        public NotEnoughBalanceException(string text) : base(text)
        {

        }
    }
}
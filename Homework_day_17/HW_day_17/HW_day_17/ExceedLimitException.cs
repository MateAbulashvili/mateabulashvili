using System;
using System.Collections.Generic;
using System.Text;

namespace HW_day_17
{
    public class ExceedLimitException : Exception
    {
        public ExceedLimitException(string text) : base(text)
        {

        }
    }
}
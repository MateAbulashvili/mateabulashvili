using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class CountryMustHaveSingleCapital : Exception
    {
        public CountryMustHaveSingleCapital(string text) : base(text)
        {

        }
    }
}
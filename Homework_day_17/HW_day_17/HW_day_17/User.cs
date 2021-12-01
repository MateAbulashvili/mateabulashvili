using System;
using System.Collections.Generic;
using System.Text;

namespace HW_day_17
{
    class User : IBAN
    {
        public User(string name, string sName)
        {
            Name = name;
            SurName = sName;
        }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
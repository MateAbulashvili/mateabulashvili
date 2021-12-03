using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Country : GeographicEntity
    {
        private string _country;
        private List<string[]> country = new List<string[]>();
        private List<string> myCountriesCities = new List<string>();
        private double _area;
        private double _quantity;
        public Country(string country, List<string[]> eachMember)
        {
            _country = country;
            this.country = eachMember;
        }

        public override void GetInfo()
        {
            int CapitalsCounter = 0;
            foreach (var item in country)
            {
                if (_country == item[(int)Indexes.CountryName])
                {
                    _quantity += double.Parse(item[1]);
                    _area += double.Parse(item[2]);
                    if (item[(int)Indexes.IsCapital] == "true")
                    {
                        CapitalsCounter++;
                        myCountriesCities.Add(item[0] + "(IsCapital)");
                    }

                    else
                        myCountriesCities.Add(item[0]);
                }
            }
            if (CapitalsCounter > 1)
                throw new Exception("CountryMustHaveSingleCapital");

            Console.WriteLine(_country);
            Console.WriteLine(_area);
            Console.WriteLine(_quantity);

            foreach (var item in myCountriesCities)
            {
                Console.WriteLine(item);
            }
        }
    }
}

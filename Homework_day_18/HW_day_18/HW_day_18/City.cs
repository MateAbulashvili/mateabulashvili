using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practice_1
{
    public class City : GeographicEntity
    {
        private List<string[]> cityList = new List<string[]>();
        private string _city;

        public City(string city, List<string[]> eachMember)
        {
            _city = city;
            this.cityList = eachMember;
        }

        public override void GetInfo()
        {
            bool hasCity = false;

            foreach (var item in cityList)
            {
                if (_city == item[(int)Indexes.CityName])
                {
                    hasCity = true;
                    for (int j = 0; j < item.Length; j++)
                    {
                        if (item[j] == "true")
                        {
                            item[j] = "Capital City";
                        }
                        Console.WriteLine(item[j]);
                    }
                }
            }

            if (hasCity == false)
            {
                File.WriteAllText(@"C:\Users\Giorgi\Desktop\log.txt", _city + " can't found");
            }
        }

    }
}

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var Line = File.ReadAllLines(@"C:\Users\admin\Desktop\Cities.txt");
            List<string[]> eachMember = new List<string[]>();


            foreach (var item in Line)
            {
                eachMember.Add(item.Split("|"));
            }


            Console.WriteLine("1)  Search Country 2)  Search City");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Write("Enter Country: ");
                    var country = Console.ReadLine();
                    Country countries = new Country(country, eachMember);
                    countries.GetInfo();
                    break;
                case 2:
                    Console.Write("Enter city: ");
                    var city = Console.ReadLine();
                    City cities = new City(city, eachMember);
                    cities.GetInfo();
                    break;
                default:
                    Console.WriteLine("invalid mode");
                    break;
            }
        }
    }
}

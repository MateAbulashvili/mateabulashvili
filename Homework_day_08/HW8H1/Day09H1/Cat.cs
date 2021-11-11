using System;
using System.Collections.Generic;
using System.Text;

namespace Day09H1
{
    class Cat
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        private int CatAge  = 0;
        private bool Sex;
        private const byte EatingPortion = 10;
        public int Age
        {
            get
            {
                return CatAge;
            }
            set
            {
                CatAge = value;
            }
        }
        public bool Gender
        {
            get
            {
                return Sex;
            }
            set
            {
                Sex = value;
            }
        }
        public void Meow(int count)
        {
            while (count > 0)
            {
                count--;
                Console.WriteLine("Meowing...");
                
            }
        }
        public void Eat(int grams)
        {
            int result = 0;
            if (grams % EatingPortion == 0)
            {
                result = grams / EatingPortion;
            }
            else
            {
                result = grams / EatingPortion + 1;
            }
            for(int i = 0; i < result; i++)
            {
                Console.WriteLine("Eating...");
            }
        }

    }
}

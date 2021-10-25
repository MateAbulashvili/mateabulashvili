using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the date of birth: ");
            int date = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month:");
            string monthOfTheYear = Console.ReadLine();
            string someVar = "";
            switch (monthOfTheYear)
            {
                case "January":
                    if (date < 20)
                        someVar = "Capricorn";
                    else
                        someVar = "Aquarius";
                    break;
                case "February":
                    if (date < 19)
                        someVar = "Aquarius";
                    else
                        someVar = "Pisces";
                    break;
                case "March":
                    if (date < 21)
                        someVar = "Pisces";
                    else
                        someVar = "Aries";
                    break;
                case "April":
                    if (date < 20)
                        someVar = "Aries";
                    else
                        someVar = "Taurus";
                    break;
                case "May":
                    if (date < 21)
                        someVar = "Taurus";
                    else
                        someVar = "Gemini";
                    break;
                case "June":
                    if (date < 21)
                        someVar = "Gemini";
                    else
                        someVar = "Cancer";
                    break;
                case "July":
                    if (date < 23)
                        someVar = "Cancer";
                    else
                        someVar = "Leo";
                    break;
                case "August":
                    if (date < 23)
                        someVar = "Leo";
                    else
                        someVar = "Virgo";
                    break;
                case "September":
                    if (date < 23)
                        someVar = "Virgo";
                    else
                        someVar = "Libra";
                    break;
                case "October":
                    if (date < 23)
                        someVar = "Libra";
                    else
                        someVar = "Scorpio";
                    break;
                case "November":
                    if (date < 22)
                        someVar = "Scorpio";
                    else
                        someVar = "Sagittarius";
                    break;
                default :
                    if (date < 22)
                        someVar = "Sagittarius";
                    else
                        someVar = "apricorn";
                    break;
            }
            Console.WriteLine($"{date} { monthOfTheYear} { someVar}");
        }
    }
}

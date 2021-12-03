using System;

namespace HW_day_17
{
    class Program
    {
        static void Main(string[] args)
        {

            ExMessage errors = new ExMessage();

            try
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string surname = Console.ReadLine();

                User user = new User(name, surname);
                try
                {
                    Console.WriteLine("create CreditIban");
                    Console.Write("Enter Your Balance in your creditiban - ");
                    double balance = double.Parse(Console.ReadLine());
                    CreditIban creditIban = user.CreditIban(balance);
                    creditIban.GetMoney(1000);
                }
                catch (ExceedLimitException ex)
                {
                    throw new Exception("due to CreditIban, error is occured ! ! ! ", ex);
                }
                try
                {
                    Console.WriteLine("Create DebitIban");
                    Console.Write("Enter Your Balance in your debitiban - ");
                    double money = double.Parse(Console.ReadLine());
                    DebitIban debitIban = user.DebitIban(money);
                    debitIban.GetMoney(1500);
                }
                catch (NotEnoughBalanceException ex)
                {
                    throw new Exception("due to Debitiban error is occured ! ! ! ", ex);
                }
            }
            catch (Exception ex1)
            {
                errors.GetAllInnerExMessageTogether(ex1);
            }

        }
    }
}
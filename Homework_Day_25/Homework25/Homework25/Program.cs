using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework25
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = GetDetails.GetOrders();
            var customers = GetDetails.GetCustomers();
            var orderCount = from c in customers // Order Count using Query Sintax
                             join o in orders
                             on c.CustomerID equals o.CustomerID
                             into someGroup
                             select new
                             {
                                 CustomerName = c.CustomerName,
                                 CustomerID = c.CustomerID,
                                 Orders = someGroup
                             };
            
            var orderCount2 = customers.GroupJoin(orders, c => c.CustomerID, o => o.CustomerID, (a, b) => new // Order count Using Method Syntax
            {
                CustomerName = a.CustomerName,
                CustomerID = a.CustomerID,
                Orders = b
            });
            Console.WriteLine("*** Each Client Order Count ***");
            foreach (var item in orderCount2)
            {
                Console.WriteLine("Customer: {0}, With ID: {1}", item.CustomerName,item.CustomerID);
                Console.WriteLine("OrderCount {0}", item.Orders.Count());
            }
            Console.WriteLine();
            Console.WriteLine("*** Each Client Sum Of Orders");
            Console.WriteLine();
            var orderSum = from a in orders //sum of orders using Query Syntax
                           group a by a.CustomerID into someGroup
                           select new
                           {
                               CustomerID = someGroup.Key,
                               OrderPrice = from a in someGroup select a.Price
                           };
            var orderSum2 = orders.GroupBy(a => a.CustomerID).Select(c => new // Sum of orders using Method Syntax
            {
                CustomerID = c.Key,
                OrderPrice = c.Select(g=>g.Price)
            });
            foreach(var item in orderSum2)
            {
                Console.WriteLine("CustomerID: {0}",item.CustomerID);
                Console.WriteLine("Sum: {0}", item.OrderPrice.Sum());
            }
            Console.WriteLine();
            Console.WriteLine("*** Each Client Min Order Price ***");
            Console.WriteLine();
            var minOrder = from a in orders // Min order Using Query Syntax
                           group a by a.CustomerID
                           into someGroup
                           select new
                           {
                               CustomerID = someGroup.Key,
                               MinAmount = from s in someGroup select s.Price
                           };
            var minOrder2 = orders.GroupBy(o => o.CustomerID).Select(a => new
            {
                CustomerID = a.Key,
                MinAmount = a.Select(g => g.Price)
            }) ;
            foreach(var item in minOrder) // Min order Using Method Syntax
            {
                Console.WriteLine("CustomerID: {0}", item.CustomerID);
                Console.WriteLine("Sum: {0}", item.MinAmount.Min());
            }            
            Console.WriteLine();
            Console.WriteLine("*** Clients With More Than One Order ***");
            Console.WriteLine();

            var more = orders.GroupBy(b => b.CustomerID).Where(a => a.Count() > 1).Select(i => new
            {

                ID = i.Key,
                MoreThanOneOrder = i.Count()
            });
            var more1 = from i in orders
                        group i by i.CustomerID into SomeGroup
                        where SomeGroup.Count() > 0
                        select new
                        {
                            ID = SomeGroup.Key,
                            MoreThanOneOrder = SomeGroup.Count()
                        };     
            foreach (var item in more1) // More Than One order
            {
                Console.WriteLine("ID: {0}", item.ID);
                Console.WriteLine("Orders: {0}",item.MoreThanOneOrder);
            }
            Console.WriteLine();
            Console.WriteLine("*** Average More Thank 10 ***");
            Console.WriteLine();
            var Average = orders.GroupBy(a => a.CustomerID).Select(c => new
            {
                CustomerID = c.Key,
                OrderPriceAvg = (c.Select(g => g.Price)).Average()
            }).Where(g => (g.OrderPriceAvg) > 2).Select(a => new
            {
                ID = a.CustomerID,
                Avg = a.OrderPriceAvg
            });
            var Average2 = orders.GroupBy(o => o.CustomerID).Where(w => w.Select(b => b.Price).Average() > 2).Select(x => new
            {
                ID = x.Key,
                Avg = (x.Select(g => g.Price)).Average()
            });
            foreach (var item in Average2)
            {
                Console.WriteLine("ID: {0}", item.ID);
                Console.WriteLine("Orders: {0}", item.Avg);
            }
        }
    }
}

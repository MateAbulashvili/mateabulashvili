using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework25
{
    public class GetDetails
    {
        public static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer{CustomerID = 1, CustomerName = "Lasha"},
                new Customer{CustomerID = 2, CustomerName = "Beka"},
                new Customer{CustomerID = 3, CustomerName = "Dimitri"},
                new Customer{CustomerID = 4, CustomerName = "Nodo"},
                new Customer{CustomerID = 5, CustomerName = "Nugzari"},
            };
        }
        public static IEnumerable<Order> GetOrders()
        {
            return new List<Order>()
            {
                new Order{OrderID = 1, Date = "20201212", Product = "Coca-cola", Price = 2, CustomerID =1},
                new Order{OrderID = 2, Date = "20201212", Product = "Pepsi", Price = 1.60, CustomerID =3},
                new Order{OrderID = 3, Date = "20211212", Product = "Staropramen", Price = 7, CustomerID =4},
                new Order{OrderID = 4, Date = "20191212", Product = "Argo", Price = 3.0, CustomerID =1},
                new Order{OrderID = 5, Date = "20201112", Product = "Bavaria", Price = 7.80, CustomerID =4},
                new Order{OrderID = 6, Date = "20201012", Product = "Fanta", Price = 3.0, CustomerID =4},
                new Order{OrderID = 7, Date = "20201212", Product = "Pechenia", Price = 3.0, CustomerID =5},
                new Order{OrderID = 8, Date = "20201212", Product = "Coca-cola", Price = 2, CustomerID =1},
                new Order{OrderID = 9, Date = "20171211", Product = "Pepsi", Price = 1.60, CustomerID =1},
                new Order{OrderID = 10, Date = "20161112", Product = "Pork", Price = 3.0, CustomerID =3},
                new Order{OrderID = 11, Date = "20151212", Product = "Noodles", Price = 5.0, CustomerID =4},
                new Order{OrderID = 12, Date = "20151209", Product = "Worsteiner", Price = 3.0, CustomerID =5},
                new Order{OrderID = 13, Date = "20201209", Product = "Fanta", Price = 3.0, CustomerID =2},
                new Order{OrderID = 14, Date = "20201209", Product = "Sausage", Price = 3.0, CustomerID =5},
                new Order{OrderID = 15, Date = "20201112", Product = "Meat", Price = 18.0, CustomerID =4},
                new Order{OrderID = 16, Date = "20191112", Product = "Milk", Price = 3.0, CustomerID =3},
                new Order{OrderID = 17, Date = "20181112", Product = "Pepsi", Price = 1.60, CustomerID =4},
                new Order{OrderID = 18, Date = "20121112", Product = "Sugar", Price = 2.40, CustomerID =5},
                new Order{OrderID = 19, Date = "20200711", Product = "Ice-tea", Price = 2, CustomerID =3},
                new Order{OrderID = 20, Date = "20200512", Product = "Peach", Price = 0.8, CustomerID =3},
            };
        }

    }
}

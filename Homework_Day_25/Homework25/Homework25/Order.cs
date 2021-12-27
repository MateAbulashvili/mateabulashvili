using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework25
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Date { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int CustomerID { get; set; }
    }
}

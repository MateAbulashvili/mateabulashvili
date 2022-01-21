using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Exceptions
{
    public class CompanyNotFoundException : Exception
    {
        public string Code = "NotFound";
        public CompanyNotFoundException(string message) : base(message)
        {

        }
    }
}

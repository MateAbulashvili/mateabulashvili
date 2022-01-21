using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Exceptions
{
    public class InternalServerException : Exception
    {
        public string Code = "InternalServerError";
        public InternalServerException(string message) : base(message)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW_day_17
{
    public class ExMessage : Exception
    {
        public void GetLastInnerExMessage(Exception ex)
        {
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            Console.WriteLine(ex);
        }
        public void GetAllInnerExMessageTogether(Exception ex)
        {
            Console.WriteLine(ex);
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_29._03._2022_.Exceptions
{
    public class NotAvailableException:Exception
    {
        public NotAvailableException(string message) : base(message)
        {

        }
    }
}

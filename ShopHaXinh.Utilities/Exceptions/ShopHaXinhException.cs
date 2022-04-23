using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHaXinh.Utilities.Exceptions
{
    public class ShopHaXinhException : Exception
    {
        public ShopHaXinhException()
        {
        }

        public ShopHaXinhException(string message)
            : base(message)
        {
        }

        public ShopHaXinhException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

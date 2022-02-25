using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string errorMessage) : base(errorMessage)
        {
            Console.WriteLine(errorMessage);
        }

        public static void NonExistentAgent()
        {
            throw new CustomException("Agent number is not implemented yet or does not exist.");
        }
    }
}

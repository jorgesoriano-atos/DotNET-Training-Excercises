using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.ConcreteImplementor
{
    public class SantanderPaymentSystem : IPaymentSystem
    {
        /// <summary>
        /// This is a Concrete Implementor
        /// </summary>

        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine($"Using Santander's Gateway for {paymentSystem}, hang on!");
        }
    }
}

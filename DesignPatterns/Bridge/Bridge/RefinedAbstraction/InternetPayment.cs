using Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.RefinedAbstraction
{
    public class InternetPayment : Payment
    {
        /// <summary>
        /// This is a refined abstraction
        /// </summary>

        public override void MakePayment()
        {
            _paymentSystem.ProcessPayment("payment via internet");
        }
    }
}

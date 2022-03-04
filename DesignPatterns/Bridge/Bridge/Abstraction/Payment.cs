using Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstraction
{
    public abstract class Payment
    {
        /// <summary>
        /// This is an abstraction
        /// </summary>

        //Bridge to the implementor interface
        public IPaymentSystem _paymentSystem;

        //This method will be implemented by the refined abstractions
        public abstract void MakePayment();

    }
}

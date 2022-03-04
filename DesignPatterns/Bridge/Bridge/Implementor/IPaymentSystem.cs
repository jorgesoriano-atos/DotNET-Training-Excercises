using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementor
{
    public interface IPaymentSystem
    {
        /// <summary>
        /// This is a Implementor Interface
        /// </summary>

        public void ProcessPayment(string paymentSystem);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenClosed.BadCode
{
    public class Currency
    {
        public Enumerations.CurrencyTypes CurrencyCode { get; set; }
        public string CurrencyName { get; set; }

        public Currency(Enumerations.CurrencyTypes currencyCode, string currencyName)
        {
            CurrencyCode = currencyCode;
            CurrencyName = currencyName;
        }
    }
}

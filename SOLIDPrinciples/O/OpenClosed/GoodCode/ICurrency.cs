using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.GoodCode
{
    public interface ICurrency
    {
        public string CurrencyName { get; }
        public string CurrencyCode { get; }

        //Base value in USD
        public double BaseValue { get; }

        public double ConvertTo(ICurrency targetCurrency, double amountToConvert);

    }
}

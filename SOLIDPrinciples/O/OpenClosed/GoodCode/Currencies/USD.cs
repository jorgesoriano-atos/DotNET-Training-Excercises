using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.GoodCode.Currencies
{
    public class USD : ICurrency
    {
        public string CurrencyName => "United States Dollar";

        public string CurrencyCode => "USD";

        public double BaseValue => 1;

        public double ConvertTo(ICurrency targetCurrency, double amountToConvert)
        {
            return (this.BaseValue * amountToConvert) / targetCurrency.BaseValue;
        }
    }
}

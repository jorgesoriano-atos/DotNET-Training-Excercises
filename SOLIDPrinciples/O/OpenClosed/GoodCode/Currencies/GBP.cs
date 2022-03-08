using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.GoodCode.Currencies
{
    public class GBP : ICurrency
    {
        public string CurrencyName => "British Pound";

        public string CurrencyCode => "GBP";

        public double BaseValue => 1.31;

        public double ConvertTo(ICurrency targetCurrency, double amountToConvert)
        {
            return (this.BaseValue * amountToConvert) / targetCurrency.BaseValue;
        }
    }

}

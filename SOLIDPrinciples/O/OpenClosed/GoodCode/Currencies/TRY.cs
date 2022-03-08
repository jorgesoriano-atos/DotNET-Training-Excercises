using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.GoodCode.Currencies
{
    public class TRY : ICurrency
    {
        public string CurrencyName => "Turkish Lira";

        public string CurrencyCode => "TRY";

        public double BaseValue => 0.069;

        public double ConvertTo(ICurrency targetCurrency, double amountToConvert)
        {
            return (this.BaseValue * amountToConvert) / targetCurrency.BaseValue;
        }
    }
}

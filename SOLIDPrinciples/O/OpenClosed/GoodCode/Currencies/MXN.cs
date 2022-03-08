using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.GoodCode.Currencies
{
    public class MXN : ICurrency
    {
        public string CurrencyName => "Mexican Peso";

        public string CurrencyCode => "MXN";

        public double BaseValue => 0.047;

        public double ConvertTo(ICurrency targetCurrency, double amountToConvert)
        {
            return (this.BaseValue * amountToConvert) / targetCurrency.BaseValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.BadCode
{
    public class CurrencyConverter
    {
        private Currency BaseCurrency;
        private Currency TargetCurrency;

        public CurrencyConverter(Currency baseCurrency, Currency targetCurrency)
        {
            BaseCurrency = baseCurrency;
            TargetCurrency = targetCurrency;
        }
        public double Convert(double amountToConvert)
        {
            switch (this.BaseCurrency.CurrencyCode)
            {
                case Enumerations.CurrencyTypes.USD:

                    if (this.TargetCurrency.CurrencyCode == Enumerations.CurrencyTypes.CAD)
                    {
                        return amountToConvert * 1.29;
                    }
                    else if (this.TargetCurrency.CurrencyCode == Enumerations.CurrencyTypes.MXN)
                    {
                        return amountToConvert * 21.23;
                    }
                    else if (this.TargetCurrency.CurrencyCode == Enumerations.CurrencyTypes.GBP)
                    {
                        return amountToConvert * 0.76;
                    }
                    else if (this.TargetCurrency.CurrencyCode == Enumerations.CurrencyTypes.EUR)
                    {
                        return amountToConvert * 0.91;
                    }
                    else if (this.TargetCurrency.CurrencyCode == Enumerations.CurrencyTypes.USD)
                    {
                        return amountToConvert;
                    }

                    break;

                default:
                    throw new NotImplementedException();
            }

            return 0;
        }
    }
}

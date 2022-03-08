using OpenClosed.BadCode;
using OpenClosed.GoodCode;
using OpenClosed.GoodCode.Currencies;

double amountToConvert = 53;

//Conversion without Open Closed Principle
Currency baseCurrency = new Currency(Enumerations.CurrencyTypes.USD, "US Dollar");
Currency targetCurrency = new Currency(Enumerations.CurrencyTypes.MXN, "Mexican Peso");

CurrencyConverter converter = new CurrencyConverter(baseCurrency, targetCurrency);
double conversionResult = converter.Convert(amountToConvert);

Console.WriteLine($"{amountToConvert} {baseCurrency.CurrencyName}s are " +
    $"{conversionResult.ToString()} {targetCurrency.CurrencyName}s");

Console.WriteLine("\n--------------------------------------------------------------------------------\n\n");

//Conversion with Open Closed Principle
ICurrency newBaseCurrency = new GBP();
ICurrency newTargetCurrency = new TRY();

conversionResult = newBaseCurrency.ConvertTo(newTargetCurrency, amountToConvert);

Console.WriteLine($"{amountToConvert} {newBaseCurrency.CurrencyName}s are " +
    $"{conversionResult} {newTargetCurrency.CurrencyName}s");

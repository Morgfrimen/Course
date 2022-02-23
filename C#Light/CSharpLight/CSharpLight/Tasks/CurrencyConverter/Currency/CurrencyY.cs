using CSharpLightConsoleTask.Tasks.CurrencyConverter.Abstracts;

namespace CSharpLightConsoleTask.Tasks.CurrencyConverter.Currency;

internal class CurrencyY : ICurrency
{
    public CurrencyY(decimal value)
    {
        Value = value;
    }

    public decimal Value { get;}
}
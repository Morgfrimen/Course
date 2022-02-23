using CSharpLightConsoleTask.Tasks.CurrencyConverter.Abstracts;

namespace CSharpLightConsoleTask.Tasks.CurrencyConverter.Currency;

internal class CurrencyZ : ICurrency
{
    public CurrencyZ(decimal value)
    {
        Value = value;
    }

    public decimal Value { get;  }
}
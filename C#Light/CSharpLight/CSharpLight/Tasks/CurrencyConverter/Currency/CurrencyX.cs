using CSharpLightConsoleTask.Tasks.CurrencyConverter.Abstracts;

namespace CSharpLightConsoleTask.Tasks.CurrencyConverter.Currency;

internal class CurrencyX : ICurrency
{
    public CurrencyX(decimal value)
    {
        Value = value;
    }

    public decimal Value { get; }
}
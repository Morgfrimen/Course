using CSharpLightConsoleTask.Tasks.CurrencyConverter.Currency;

namespace CSharpLightConsoleTask.Tasks.CurrencyConverter.Abstracts;

internal interface IBalance
{
    public CurrencyX BalanceCurrencyX { get; set; }
    public CurrencyY BalanceCurrencyY { get; set; }
    public CurrencyZ BalanceCurrencyZ { get; set; }
}
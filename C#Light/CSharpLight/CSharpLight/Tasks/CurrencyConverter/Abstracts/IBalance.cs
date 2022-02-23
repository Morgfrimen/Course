using CSharpLightConsoleTask.Tasks.CurrencyConverter.Currency;

namespace CSharpLightConsoleTask.Tasks.CurrencyConverter.Abstracts;

internal interface IBalance
{
    public CurrencyEnum CurrencyEnum { get; set; }
    public IBalance ConvertCurrency(CurrencyEnum toCurrencyEnum);
}
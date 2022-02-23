using CSharpLightConsoleTask.Tasks.Abstracts;
using CSharpLightConsoleTask.Tasks.CurrencyConverter.Abstracts;
using CSharpLightConsoleTask.Tasks.CurrencyConverter.Currency;

namespace CSharpLightConsoleTask.Tasks.CurrencyConverter;

internal class CurrencyConverter : IConsoleTask
{
    private CurrencyX ConvertToCurrencyX(ICurrency currency) =>
        currency switch
        {
            CurrencyX currencyX => currencyX,
            CurrencyY => new CurrencyX(currency.Value * 100),
            CurrencyZ => new CurrencyX(currency.Value / 50),
            _ => throw new NotImplementedException("Конвертация данной валюты не реализована")
        };
    private CurrencyY ConvertToCurrencyY(ICurrency currency) =>
        currency switch
        {
            CurrencyX => new CurrencyY(currency.Value / 100),
            CurrencyY currencyY => currencyY,
            CurrencyZ => new CurrencyY(currency.Value * 30),
            _ => throw new NotImplementedException("Конвертация данной валюты не реализована")
        };
    private CurrencyZ ConvertToCurrencyZ(ICurrency currency) =>
        currency switch
        {
            CurrencyX => new CurrencyZ(currency.Value * 50),
            CurrencyY => new CurrencyZ(currency.Value / 30),
            CurrencyZ currencyZ => currencyZ,
            _ => throw new NotImplementedException("Конвертация данной валюты не реализована")
        };


    public void RunTask()
    {
        var user = new User();

    }
}
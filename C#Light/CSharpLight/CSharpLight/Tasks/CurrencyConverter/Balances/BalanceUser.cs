using CSharpLightConsoleTask.Tasks.CurrencyConverter.Abstracts;
using CSharpLightConsoleTask.Tasks.CurrencyConverter.Currency;

namespace CSharpLightConsoleTask.Tasks.CurrencyConverter.Balances;

internal class BalanceUser : IBalance
{
    public BalanceUser(decimal balanceCurrencyX, decimal balanceCurrencyY, decimal balanceCurrencyZ)
    {
        BalanceCurrencyX = new CurrencyX(){ balanceCurrencyX };
        BalanceCurrencyY = balanceCurrencyY;
        BalanceCurrencyZ = balanceCurrencyZ;
    }

    public CurrencyX BalanceCurrencyX { get; set; }
    public CurrencyY BalanceCurrencyY { get; set; }
    public CurrencyZ BalanceCurrencyZ { get; set; }
}
using System.Globalization;
using CSharpLight.Tasks.Abstracts;

namespace CSharpLight.Tasks;

public class Magazine : IConsoleTask
{
    public void Run()
    {
        const double DefaultGoldInWallet = 500;
        const double DefaultCrystalInWallet = 5;
        const double PriceCrystal = 100;
        Console.Write("Введите первоначальное количество золота в кошельке: ");
        if (!double.TryParse(Console.ReadLine(), NumberStyles.Any,CultureInfo.InvariantCulture, out var goldInWallet))
        {
            goldInWallet = DefaultGoldInWallet;
        }
        Console.WriteLine($"Предложение купить кристалл по цене {PriceCrystal}, сколько кристаллов купить?");
        if (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out var countBayCrystal))
        {
            countBayCrystal = DefaultCrystalInWallet;
        }

        var crystalInWallet = countBayCrystal;
        goldInWallet = goldInWallet - countBayCrystal * PriceCrystal;
        Console.WriteLine($"Золота в кошельке: {goldInWallet}");
        Console.WriteLine($"Кристаллов в кошельке: {crystalInWallet}");
    }
}
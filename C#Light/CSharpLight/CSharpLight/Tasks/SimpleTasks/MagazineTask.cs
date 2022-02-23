using System.Globalization;
using CSharpLightConsoleTask.Tasks.Abstracts;

namespace CSharpLightConsoleTask.Tasks.SimpleTasks;

public class MagazineTask : IConsoleTask
{
    public void RunTask()
    {
        const double defaultGoldInWallet = 500;
        const double defaultCrystalInWallet = 5;
        const double priceCrystal = 100;
        Console.Write("Введите первоначальное количество золота в кошельке: ");

        if (!double.TryParse(Console.ReadLine(),NumberStyles.Any,CultureInfo.InvariantCulture,out var goldInWallet))
        {
            goldInWallet = defaultGoldInWallet;
        }

        Console.WriteLine($"Предложение купить кристалл по цене {priceCrystal}, сколько кристаллов купить?");

        if (!double.TryParse(Console.ReadLine(),NumberStyles.Any,CultureInfo.InvariantCulture,out var countBayCrystal))
        {
            countBayCrystal = defaultCrystalInWallet;
        }

        var crystalInWallet = countBayCrystal;
        goldInWallet = goldInWallet - countBayCrystal * priceCrystal;
        Console.WriteLine($"Золота в кошельке: {goldInWallet}");
        Console.WriteLine($"Кристаллов в кошельке: {crystalInWallet}");
    }
}
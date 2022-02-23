using CSharpLightConsoleTask.Tasks.Abstracts;

namespace CSharpLightConsoleTask.Tasks.CurrencyConverter;

public class CurrencyConverter : IConsoleTask
{
    public void RunTask()
    {
        var userBalanceCurrencyX = 500m;
        var userBalanceCurrencyY = 0m;
        var userBalanceCurrencyZ = 0m;
        var isRunProgram = true;

        while (isRunProgram)
        {
            Console.WriteLine("Введите команду:");

            Console.Write($"1-Сконвертировать в CurrencyX{Environment.NewLine}" + $"2-Сконвертировать в CurrencyY{Environment.NewLine}" +
                          $"3-Сконвертировать в CurrencyZ{Environment.NewLine}" + $"4-Показать баланс{Environment.NewLine}" +
                          $"5-Выход из программы{Environment.NewLine}");
            _ = ushort.TryParse(Console.ReadKey().KeyChar.ToString(),out var command);

            switch (command)
            {
                case 1:
                    if (GetSumConvertValue(userBalanceCurrencyX,out var sumConvert))
                    {
                        break;
                    }

                    Console.WriteLine("Сконвертировать в CurrencyY?");
                    Console.WriteLine($"1-да{Environment.NewLine}2-нет");

                    if (short.TryParse(Console.ReadKey().KeyChar.ToString(),out var commandConvertCurrency) is false)
                    {
                        break;
                    }

                    switch (commandConvertCurrency)
                    {
                        case 1:
                            userBalanceCurrencyY = sumConvert * 100;
                            break;
                        case 2:
                            userBalanceCurrencyZ = sumConvert / 50;
                            break;
                    }

                    userBalanceCurrencyX -= sumConvert;
                    break;
                case 2:
                    if (GetSumConvertValue(userBalanceCurrencyY,out sumConvert))
                    {
                        break;
                    }

                    Console.WriteLine("Сконвертировать в CurrencyX?");
                    Console.WriteLine($"1-да{Environment.NewLine}2-нет");

                    if (short.TryParse(Console.ReadKey().KeyChar.ToString(),out commandConvertCurrency) is false)
                    {
                        break;
                    }

                    switch (commandConvertCurrency)
                    {
                        case 1:
                            userBalanceCurrencyX = sumConvert / 100;
                            break;
                        case 2:
                            userBalanceCurrencyZ = sumConvert * 30;
                            break;
                    }

                    userBalanceCurrencyY -= sumConvert;
                    break;
                case 3:
                    if (GetSumConvertValue(userBalanceCurrencyZ,out sumConvert))
                    {
                        break;
                    }

                    Console.WriteLine("Сконвертировать в CurrencyY?");
                    Console.WriteLine($"1-да{Environment.NewLine}2-нет");

                    if (short.TryParse(Console.ReadKey().KeyChar.ToString(),out commandConvertCurrency) is false)
                    {
                        break;
                    }

                    switch (commandConvertCurrency)
                    {
                        case 1:
                            userBalanceCurrencyY = sumConvert / 30;
                            break;
                        case 2:
                            userBalanceCurrencyX = sumConvert * 50;
                            break;
                    }

                    userBalanceCurrencyZ -= sumConvert;
                    break;
                case 4:
                    Console.Clear();

                    Console.Write($"Ваш баланс:{Environment.NewLine}" + $"CurrencyX -> {userBalanceCurrencyX}{Environment.NewLine}" +
                                  $"CurrencyY -> {userBalanceCurrencyY}{Environment.NewLine}" +
                                  $"CurrencyZ -> {userBalanceCurrencyZ}{Environment.NewLine}");
                    EndWorkCommand();
                    break;
                case 5:
                    Console.WriteLine("Выход из программы");
                    isRunProgram = false;
                    break;
                default:
                    Console.WriteLine("Команда не распознана, попробуйте ещё раз...");
                    EndWorkCommand();
                    break;
            }

            Console.Clear();
        }
    }

    private static void EndWorkCommand()
    {
        Console.WriteLine("Нажмите любую кнопку для продолжения работы приложения");
        _ = Console.ReadKey();
    }

    private static bool GetSumConvertValue(decimal userBalance,out decimal sumConvert)
    {
        Console.Clear();
        Console.WriteLine($"Какую сумму сконвертировать денег? Доступно: {userBalance}");

        if (decimal.TryParse(Console.ReadLine(),out sumConvert) is false)
        {
            return true;
        }

        if (sumConvert > userBalance)
        {
            Console.WriteLine("Недостаточно средств для конвертации");
            return true;
        }

        Console.Clear();
        return false;
    }
}
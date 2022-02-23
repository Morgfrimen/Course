using CSharpLight.Tasks.Abstracts;

namespace CSharpLight.Tasks;

public class ForTask : IConsoleTask
{
    public void Run()
    {
        const uint DefaultCountPrintUserMessage = 10;
        Console.WriteLine("Введите сообщение");
        var userMessage = Console.ReadLine();
        Console.Write("Введите количесво раз отображения сообщения: ");
        if (!uint.TryParse(Console.ReadLine(), out var countPrintMessage))
        {
            countPrintMessage = DefaultCountPrintUserMessage;
        }

        uint currentCountPrintMessage = default;
        do
        {
            Console.WriteLine(userMessage);
            currentCountPrintMessage++;
        } while (currentCountPrintMessage < countPrintMessage);

    }
}
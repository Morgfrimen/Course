using CSharpLightConsoleTask.Tasks.Abstracts;

namespace CSharpLightConsoleTask.Tasks.SimpleTasks;

public class ForTask : IConsoleTask
{
    public void RunTask()
    {
        const uint DefaultCountPrintUserMessage = 10;

        Console.WriteLine("Введите сообщение");
        var userMessage = Console.ReadLine();
        Console.Write("Введите количесво раз отображения сообщения: ");

        if (uint.TryParse(Console.ReadLine(),out var countPrintMessage) is false)
        {
            countPrintMessage = DefaultCountPrintUserMessage;
        }

        uint currentCountPrintMessage = default;

        do
        {
            Console.WriteLine(userMessage);
            currentCountPrintMessage++;
        }
        while (currentCountPrintMessage < countPrintMessage);
    }
}
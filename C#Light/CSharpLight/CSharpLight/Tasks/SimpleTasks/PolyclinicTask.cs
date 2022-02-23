using CSharpLightConsoleTask.Tasks.Abstracts;

namespace CSharpLightConsoleTask.Tasks.SimpleTasks;

public class PolyclinicTask : IConsoleTask
{
    public void RunTask()
    {
        const uint DefaultPeople = 10;
        var receptionTime = new TimeOnly(0, 10, 0);

        Console.Write("Количество людей в очереди: ");
        if (!uint.TryParse(Console.ReadLine(), out var countPeopleInQueue)) 
            countPeopleInQueue = DefaultPeople;
        var resultStandIsQueue = new TimeOnly().AddMinutes(countPeopleInQueue * receptionTime.Minute);
        Console.WriteLine($"Всего в очереди примерно придётся простоять: {resultStandIsQueue.ToString("h часа mm минут")}");
    }
}
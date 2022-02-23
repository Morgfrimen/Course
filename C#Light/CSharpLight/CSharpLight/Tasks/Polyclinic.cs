using CSharpLight.Tasks.Abstracts;

namespace CSharpLight.Tasks;

public class Polyclinic : IConsoleTask
{
    public void Run()
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
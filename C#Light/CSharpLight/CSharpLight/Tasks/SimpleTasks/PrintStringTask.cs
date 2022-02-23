using CSharpLightConsoleTask.Tasks.Abstracts;

namespace CSharpLightConsoleTask.Tasks.SimpleTasks;

public class PrintStringTask : IConsoleTask
{
    public void Run()
    {
        
        Console.Write("Как Вас зовут?=> ");
        var nameUser = $"Вас зовут {Console.ReadLine()}, ";
        Console.Write("Какой Ваш возраст?=> ");
        var ageUser = $"вам {Console.ReadLine()}, ";
        Console.Write("Какой Ваш знак зодиака?=> ");
        var zodiacSignUser = $"вы {Console.ReadLine()}, ";
        Console.Write("Где Вы работаете?=> ");
        var workUser = $"и Вы работаете на {Console.ReadLine()}";

        var resultMessage = nameUser + ageUser + zodiacSignUser + workUser;

        Console.WriteLine(resultMessage);
    }
}
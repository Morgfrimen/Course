using System.Text;
using CSharpLight.Tasks.Abstracts;

namespace CSharpLight.Tasks;

public class PrintString : IConsoleTask
{
    public void Run()
    {
        var stringBuilder = new StringBuilder();
        Console.Write("Как Вас зовут?=> ");
        stringBuilder.Append($"Вас зовут {Console.ReadLine()}, ");
        Console.Write("Какой Ваш возраст?=> ");
        stringBuilder.Append($"вам {Console.ReadLine()}, ");
        Console.Write("Какой Ваш знак зодиака?=> ");
        stringBuilder.Append($"вы {Console.ReadLine()}, ");
        Console.Write("Где Вы работаете?=> ");
        stringBuilder.Append($"и Вы работаете на {Console.ReadLine()}");

        Console.WriteLine(stringBuilder.ToString());
    }
}
using CSharpLight.Tasks;
using CSharpLight.Tasks.Abstracts;

Console.WriteLine("Задача про картинки в 3 в ряд");
RunConsoleTask(new ThreeImageToRow());
Console.ReadLine();

static void RunConsoleTask(IConsoleTask task)
{
    Console.WriteLine(new string('-',50));
    task.Run();
    Console.WriteLine(new string('-', 50));
}
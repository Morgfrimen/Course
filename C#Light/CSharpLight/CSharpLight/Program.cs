using CSharpLight.Tasks;
using CSharpLight.Tasks.Abstracts;

RunConsoleTask(new Polyclinic());

static void RunConsoleTask(IConsoleTask task)
{
    Console.Clear();
    Console.WriteLine(new string('-',50));
    task.Run();
    Console.WriteLine(new string('-', 50));
    Console.ReadLine();
}
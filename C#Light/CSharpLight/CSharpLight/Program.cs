using CSharpLightConsoleTask.Tasks.Abstracts;
using CSharpLightConsoleTask.Tasks.SimpleTasks;

RunConsoleTask(new ForExitTask());

static void RunConsoleTask(IConsoleTask task)
{
    Console.Clear();
    Console.WriteLine(new string('-',50));
    task.Run();
    Console.WriteLine(new string('-', 50));
    Console.ReadLine();
}
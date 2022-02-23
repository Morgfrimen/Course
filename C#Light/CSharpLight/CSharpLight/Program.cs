using CSharpLightConsoleTask.Tasks.Abstracts;
using CSharpLightConsoleTask.Tasks.CurrencyConverter;

RunConsoleTask(new CurrencyConverter());

static void RunConsoleTask(IConsoleTask task)
{
    Console.Clear();
    Console.WriteLine(new string('-',50));
    task.RunTask();
}
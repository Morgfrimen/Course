﻿using CSharpLight.Tasks.Abstracts;

namespace CSharpLight.Tasks;

public class ForExitTask : IConsoleTask
{
    public void Run()
    {
        const string ExitCommand = "exit";
        Console.WriteLine("Программа с условием выхода");
        var isExitProgram = false;
        while (!isExitProgram)
        {
            Console.WriteLine("Выполнение команды...");
            Console.WriteLine(new string('=',50));
            Console.WriteLine("Введите команду");
            var command = Console.ReadLine().ToLower();
            if (command is ExitCommand)
            {
                isExitProgram = true;
                Console.WriteLine("Конец выполнения программы");
            }
        }

    }
}
using CSharpLightConsoleTask.Tasks.Abstracts;

namespace CSharpLightConsoleTask.Tasks.SimpleTasks;

public class ThreeImageToRowTask : IConsoleTask
{
    public void RunTask()
    {
        var countUserImages = 52;
        var countPrintImageToRow = 3;
        var countCompletedRows = countUserImages / countPrintImageToRow;
        var countImagesLeft = countUserImages - countPrintImageToRow * countCompletedRows;
        Console.WriteLine($"Количество полностью заполненых рядов с изображением: {countCompletedRows}");
        Console.WriteLine($"Осталось изображений: {countImagesLeft}");
    }
}
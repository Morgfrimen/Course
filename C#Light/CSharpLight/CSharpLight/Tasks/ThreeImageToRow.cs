using CSharpLight.Tasks.Abstracts;

namespace CSharpLight.Tasks;

public class ThreeImageToRow : IConsoleTask
{
    public void Run()
    {
        var countUserImages = 52;
        var countPrintImageToRow = 3;
        var countCompletedRows = countUserImages / countPrintImageToRow;
        var countImagesLeft = countUserImages - countPrintImageToRow * countCompletedRows;
        Console.WriteLine($"Количество полностью заполненых рядов с изображением: {countCompletedRows}");
        Console.WriteLine($"Осталось изображений: {countImagesLeft}");
    }
}
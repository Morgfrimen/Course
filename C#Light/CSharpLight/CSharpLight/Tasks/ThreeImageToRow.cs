using CSharpLight.Tasks.Abstracts;

namespace CSharpLight.Tasks;

public class ThreeImageToRow : IConsoleTask
{
    public void Run()
    {
        const int countUserImages = 52;
        const int countPrintImageToRow = 3;
        const int countCompletedRows = countUserImages / countPrintImageToRow;
        const int countImagesLeft = countUserImages - 3 * countCompletedRows;
        Console.WriteLine($"Количество полностью заполненых рядов с изображением: {countCompletedRows}");
        Console.WriteLine($"Осталось изображений: {countImagesLeft}");
    }
}
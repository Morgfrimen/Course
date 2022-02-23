using CSharpLightConsoleTask.Tasks.Abstracts;

namespace CSharpLightConsoleTask.Tasks.SimpleTasks;

internal class FirstTask : IConsoleTask
{
    public void RunTask()
    {
        var moneyInWallet = 100.55m;
        var integerValue = 100;
        var doubleFloatingNumber = 43.55d;
        var floatingNumber = 34.223f;
        byte memoryByte = 255;
        short shortIntegerValue = 256;
        uint positiveIntegerValue = 299;
        ushort positiveShortIntegerValue = 2000;
        var namePerson = "Магнэто";
        var firstCharInNamePerson = namePerson[0];
        dynamic objectCom = new object();
        var noDynamicValue = floatingNumber + 23;
    }
}
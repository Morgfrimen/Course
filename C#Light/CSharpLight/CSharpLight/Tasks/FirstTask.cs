using CSharpLight.Tasks.Abstracts;

internal class FirstTask : IConsoleTask
{
    public void Run()
    {
        decimal moneyInWallet = 100.55m;
        int integerValue = 100;
        double doubleFloatingNumber = 43.55d;
        float floatingNumber = 34.223f;
        byte memoryByte = 255;
        short shortIntegerValue = 256;
        uint positiveIntegerValue = 299;
        ushort positiveShortIntegerValue = 2000;
        string namePerson = "Магнэто";
        char firstCharInNamePerson = namePerson[0];
        dynamic objectCom = new object();
        var noDynamicValue = floatingNumber + 23;
    }
}
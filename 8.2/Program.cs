using System;
try
{
    Console.WriteLine("Для ввода используйте следующие символы: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F");
    IHexadec1 hex = new Hexadec1();
    hex.Input();
    hex.Output();
    Hexadec1 hex1 = new Hexadec1();
    hex1.Input();
    hex1.Output();
    hex.Addition(hex1);
    hex.Multi(hex1);

}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}
interface IHexadec1
{
    void Input();
    void Output();
    void Addition(Hexadec1 Hexadec1);
    void Multi(Hexadec1 Hexadec1);
}
abstract class Hexadec : IHexadec1
{
    protected string ch;
    protected string FP;
    public abstract void Input();
    public abstract void Output();
    public abstract void Addition(Hexadec1 Hexadec1);
    public abstract void Multi(Hexadec1 Hexadec1);
}
class Hexadec1 : Hexadec
{
    public override void Input()
    {
        Console.WriteLine("Введите целую часть");
        ch = Console.ReadLine();
        Console.WriteLine("Введите дробную часть");
        string FI = Console.ReadLine().PadRight(3, '0');
        FP = FI.Substring(0, 3);
    }
    public override void Output()
    {
        Console.WriteLine($"Шестнадцатиричное число: {ch}.{FP}");
    }
    public override void Addition(Hexadec1 Hexadec1)
    {
        int int1 = Convert.ToInt32(ch, 16);
        double frac1 = Convert.ToInt32(FP, 16) / Math.Pow(16, FP.Length);
        double num1 = int1 + frac1;
        int int2 = Convert.ToInt32(Hexadec1.ch, 16);
        double frac2 = Convert.ToInt32(Hexadec1.FP, 16) / Math.Pow(16, Hexadec1.FP.Length);
        double num2 = int2 + frac2;
        double result = num1 + num2;
        int resultI = (int)Math.Truncate(result);
        double resultFrac = result - resultI;
        int fracInt = (int)(resultFrac * Math.Pow(16, 3));
        string fracHex = Convert.ToString(fracInt, 16).PadLeft(3, '0');
        Console.WriteLine($"Результат сложения: {resultI.ToString("X")}.{fracHex}");
    }
    public override void Multi(Hexadec1 Hexadec1)
    {
        int int1 = Convert.ToInt32(ch, 16);
        double frac1 = Convert.ToInt32(FP, 16) / Math.Pow(16, FP.Length);
        double num1 = int1 + frac1;
        int int2 = Convert.ToInt32(Hexadec1.ch, 16);
        double frac2 = Convert.ToInt32(Hexadec1.FP, 16) / Math.Pow(16, Hexadec1.FP.Length);
        double num2 = int2 + frac2;
        double result = num1 * num2;
        int resultI = (int)Math.Truncate(result);
        double resultFrac = result - resultI;
        int resultFracInt = (int)(resultFrac * Math.Pow(16, 3));
        string fracHex = Convert.ToString(resultFracInt, 16).PadLeft(3, '0');
        Console.WriteLine($"Результат умножения: {resultI.ToString("X")}.{fracHex}");
    }
}
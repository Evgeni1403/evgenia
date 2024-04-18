using System;

interface ICoordinate
{
    double CalculateDistance(ICoordinate point);
}

abstract class Koord : ICoordinate
{
    public int Degrees { get; set; }
    public float Minutes { get; set; }
    public char Direction { get; set; }

    public Koord(int degrees, float minutes, char direction)
    {
        Degrees = degrees;
        Minutes = minutes;
        Direction = direction;
    }

    public abstract double CalculateDistance(ICoordinate point);
}

class GPS : Koord
{
    public GPS(int degrees, float minutes, char direction) : base(degrees, minutes, direction)
    {
    }

    public override double CalculateDistance(ICoordinate point)
    {
        Koord otherPoint = point as Koord;
        double latDistance = Math.Abs(Degrees - otherPoint.Degrees) * 111;
        double lonDistance = Math.Abs(Degrees - otherPoint.Degrees) * 111 * Math.Cos((Degrees + otherPoint.Degrees) / 2);
        return Math.Sqrt(latDistance * latDistance + lonDistance * lonDistance);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты первой точки:");
        Console.Write("Градусы: ");
        int degrees1 = int.Parse(Console.ReadLine());
        Console.Write("Минуты: ");
        float minutes1 = float.Parse(Console.ReadLine());
        Console.Write("Направление (N, S, W или E): ");
        char direction1 = char.Parse(Console.ReadLine().ToUpper());

        Console.WriteLine("\nВведите координаты второй точки:");
        Console.Write("Градусы: ");
        int degrees2 = int.Parse(Console.ReadLine());
        Console.Write("Минуты: ");
        float minutes2 = float.Parse(Console.ReadLine());
        Console.Write("Направление (N, S, W или E): ");
        char direction2 = char.Parse(Console.ReadLine().ToUpper());

        GPS point1 = new GPS(degrees1, minutes1, direction1);
        GPS point2 = new GPS(degrees2, minutes2, direction2);

        double distance = point1.CalculateDistance(point2);
        Console.WriteLine($"\nРасстояние между точками: {distance} км");
    }
}
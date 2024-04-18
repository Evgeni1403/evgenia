using System;
using System.Collections.Generic;

abstract class Животное
{
    public string Name { get; set; }

    protected Животное(string name)
    {
        Console.WriteLine($"Конструктор Животное: {name}");
        Name = name;
    }

    ~Животное()
    {
        Console.WriteLine($"Деструктор Животное: {Name}");
    }

    public abstract void Move();
}

abstract class Рыба : Животное
{
    protected Рыба(string name) : base(name)
    {
        Console.WriteLine($"Конструктор Рыба: {name}");
    }

    ~Рыба()
    {
        Console.WriteLine($"Деструктор Рыба: {Name}");
    }
}

abstract class Млекопитающие : Животное
{
    protected Млекопитающие(string name) : base(name)
    {
        Console.WriteLine($"Конструктор Млекопитающие: {name}");
    }

    ~Млекопитающие()
    {
        Console.WriteLine($"Деструктор Млекопитающие: {Name}");
    }
}

abstract class Птица : Животное
{
    protected Птица(string name) : base(name)
    {
        Console.WriteLine($"Конструктор Птица: {name}");
    }

    ~Птица()
    {
        Console.WriteLine($"Деструктор Птица: {Name}");
    }
}

class Дельфин : Млекопитающие
{
    public Дельфин(string name) : base(name)
    {
        Console.WriteLine($"Конструктор Дельфин: {name}"); // Вывод информации о конструкторе
    }

    // Переопределение метода Move для класса Дельфин
    public override void Move()
    {
        Console.WriteLine($"{Name} плавает в океане.");
    }

    // Деструктор класса Дельфин
    ~Дельфин()
    {
        Console.WriteLine($"Деструктор Дельфин: {Name}");
    }
}

class Пингвин : Птица
{
    public Пингвин(string name) : base(name)
    {
        Console.WriteLine($"Конструктор Пингвин: {name}");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} ходит и плавает.");
    }

    ~Пингвин()
    {
        Console.WriteLine($"Деструктор Пингвин: {Name}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите имя для дельфина:");
        string dolphinName = Console.ReadLine();

        Console.WriteLine("Введите имя для пингвина:");
        string penguinName = Console.ReadLine();

        List<Животное> animals = new List<Животное>
        {
            new Дельфин(dolphinName),
            new Пингвин(penguinName)
        };

        foreach (var animal in animals)
        {
            animal.Move();
            Console.WriteLine($"Имя: {animal.Name}");
        }

        Console.WriteLine("Завершение работы программы...");
    }
}


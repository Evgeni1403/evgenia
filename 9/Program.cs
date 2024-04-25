using System;
using System.Collections.Generic;


interface IПлавающий
{
    void Плавать(); 
}


interface IЛетающий
{
    void Летать(); 
}


interface IХодящий
{
    void Ходить(); 
}


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

    
    public virtual void Move()
    {
        MakeSound(); 
    }

    
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} издает звук.");
    }
}


class Рыба : Животное, IПлавающий
{
    public Рыба(string name) : base(name) 
    {
        Console.WriteLine($"Конструктор Рыба: {name}");
    }

    ~Рыба() 
    {
        Console.WriteLine($"Деструктор Рыба: {Name}");
    }

    
    public void Плавать()
    {
        Console.WriteLine($"{Name} плавает.");
    }

    
    public override void Move()
    {
        Плавать();
        base.Move(); 
    }

   
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} молчит в воде.");
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


abstract class Птица : Животное, IЛетающий
{
    protected Птица(string name) : base(name) 
    {
        Console.WriteLine($"Конструктор Птица: {name}");
    }

    ~Птица() 
    {
        Console.WriteLine($"Деструктор Птица: {Name}");
    }

    public abstract void Летать(); 

    public override void Move() 
    {
        Летать();
        base.Move(); 
    }
}


class Дельфин : Млекопитающие, IПлавающий
{
    public Дельфин(string name) : base(name) 
    {
        Console.WriteLine($"Конструктор Дельфин: {name}");
    }

    public override void Move() 
    {
        Плавать();
        base.Move(); 
    }

    public void Плавать() 
    {
        Console.WriteLine($"{Name} плавает.");
    }

    public override void MakeSound() 
    {
        Console.WriteLine($"{Name} издает щелчки.");
    }

    ~Дельфин() 
    {
        Console.WriteLine($"Деструктор Дельфин: {Name}");
    }
}


class Пингвин : Птица, IПлавающий, IХодящий
{
    public Пингвин(string name) : base(name) 
    {
        Console.WriteLine($"Конструктор Пингвин: {name}");
    }

    public override void Летать() 
    {
        Console.WriteLine($"{Name} не умеет летать.");
    }

    public void Плавать() 
    {
        Console.WriteLine($"{Name} плавает.");
    }

    public void Ходить() 
    {
        Console.WriteLine($"{Name} ходит.");
    }

    public override void Move() 
    {
        Ходить();
        Плавать();
        base.Move(); 
    }

    public override void MakeSound() 
    {
        Console.WriteLine($"{Name} издает крики.");
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
        
        Дельфин дельфин = new Дельфин("Дельфи");
        Пингвин пингвин = new Пингвин("Пинги");
        Рыба рыба = new Рыба("Рыбкин");

        
        List<Животное> animals = new List<Животное> { дельфин, пингвин, рыба };
        Console.WriteLine();
        foreach (var animal in animals)
        {
            animal.Move();
            Console.WriteLine($"Имя: {animal.Name}");
            Console.WriteLine();
        }
    }
}

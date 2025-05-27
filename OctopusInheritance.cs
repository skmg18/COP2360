using System;

class Octopus
{
    public readonly string Name;
    public readonly int Legs = 8;

    public Octopus(string name)
    {
        Name = name;
    }

    public virtual void SayHello()
    {
        Console.WriteLine($"Hi, I'm {Name} and I have {Legs} legs.");
    }
}

// Inheriting from Octopus
class GiantOctopus : Octopus
{
    public double SizeInMeters;

    public GiantOctopus(string name, double size) : base(name)
    {
        SizeInMeters = size;
    }

    // Overriding the base method
    public override void SayHello()
    {
        Console.WriteLine($"I'm a GIANT octopus named {Name}, I'm {SizeInMeters} meters long and I have {Legs} legs!");
    }
}

class Program
{
    static void Main()
    {
        Octopus regular = new Octopus("Jack");
        GiantOctopus giant = new GiantOctopus("Kraken", 12.5);

        regular.SayHello();
        giant.SayHello();
    }
}
using System.Xml.Linq;

internal class Animal
{
    public string animalName { get; set; } = "";
    public virtual void MakeSound()
    {
        Console.WriteLine($"");
    }
}

internal class Dog: Animal
{
    public Dog(string name)
    {
        animalName = name;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{animalName}はわんわんわんわんわんわんわんわんわ何あなmと鳴きます");
    }
}

internal class Cat : Animal
{
    public Cat(string name)
    {
        animalName = name;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{animalName}はにゃーと鳴きます");
    }
}

internal class Person : Animal
{
    public Person(string name)
    {
        animalName = name;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{animalName}はクァwせdrftgyふじこpと鳴きます");
    }
}

internal class PersonClient
{
    static void Main(string[] args)
    {
        Animal[] sounds = { new Dog("いっぬ"), new Cat("ネコ"), new Person("人") };
        foreach(Animal s in sounds)
        {
            s.MakeSound();
        }

    }
}
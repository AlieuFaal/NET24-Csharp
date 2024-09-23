// Animal animal= new Animal() {Name = "Heffaklump"};
// Cat cat= new Cat() {Name = "Pelle"};
// Dog dog= new Dog(){Name = "Fido"};

// Char myChar = 'A';
// System.Console.WriteLine((int)myChar);

Animal myAnimal= new Cat {Name = "Pelle"};
Cat myCat= (Cat)myAnimal;
myCat.Mew();

// Animal[] animals = new Animal[]
// {
//     new Cat() {Name = "Pelle"},
//     new Cat() {Name = "Fido"},
//     new Dog() {Name = "Bosse"},
//     new Dog() {Name = "Måns"}   
// };

// foreach (Animal animal in animals)
// {
//     animal.Run();
//     animal.Walk();
//     System.Console.WriteLine();
// }

// animal.Run();

// System.Console.WriteLine();

// cat.Run();
// cat.Mew();
// cat.Walk();

// System.Console.WriteLine();

// dog.Run();
// dog.Bark();



Console.ReadKey();

abstract class Animal
{
    required public string Name { get; set; }

    public abstract void Run();

    public virtual void Walk()
    {
        Console.WriteLine($"{Name} is walking!");
    }
}

class Cat : Animal
{
    public void Mew()
    {
        System.Console.WriteLine($"{Name}: Meow!");
    }

    public override void Run()
    {
        Console.WriteLine($"The cat {Name} is running!");
    }

    public override void Walk()
    {
        base.Walk();
        System.Console.WriteLine($"{Name} says: HEeeY I'M Walking h'eere");
    }

}

class Dog : Animal
{
    public void Bark()
    {
        System.Console.WriteLine($"{Name}: Woof Woof!");
    }

    public override void Run()
    {
        Console.WriteLine($"The dog {Name} is running!");
    }

    public override void Walk()
    {
        System.Console.WriteLine($"{Name} says: HEeeY I'M Walking h'eere");
    }
}
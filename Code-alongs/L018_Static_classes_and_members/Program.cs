Cat myCat = new Cat() {name = "Pelle Svanslös"};

myCat.Greet();

Cat.Hello("Ali");

Cat.PrintNumberOfLives();

class Cat
{
public string name;

public static int numberoflives = 9;

public void Greet()
{
    System.Console.WriteLine($"Hi my name is {name} and i have {numberoflives} lives.");
}

public static void Hello(string name)
{
    System.Console.WriteLine($"Hi my name is {name} and i have {numberoflives} lives.");
}

public static void PrintNumberOfLives()
{
    System.Console.WriteLine($"Every cat has {numberoflives} lives...");
}

}
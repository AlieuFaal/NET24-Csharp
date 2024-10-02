
// Keyword new anropar konstruktorn på en klass, som skapar objektet
// och returnerar en referens till det nyskapade objektet. 

// Cat cat1 = new Cat(); // Tre olika sätt att skriva samma sak.
// var cat2 = new Cat();
Cat cat = new();  
Cat cat2 = new("Måns", 10);

System.Console.WriteLine($"My name is {cat.name} and I'm {cat.age} years old.");
System.Console.WriteLine($"My name is {cat2.name} and I'm {cat2.age} years old.");

class Cat
{
    public string name = "Default Name";

    public int age = 0;

    private bool isHungry;

    // Constructor
    public Cat()
    {
        this.name = "Pelle";
        this.age = 5; 
    }

    public Cat(string name)
    {
        this.name = name;
        this.isHungry = false;
    }

    public Cat(string name, int age)
    {
        this.name = name;
        this.age = age; 
    }
}
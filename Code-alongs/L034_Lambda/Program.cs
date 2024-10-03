// Func<int,int> square = Square;

// Func<int,int> square = x => x * x;

// System.Console.WriteLine(square(5));

// static int Square(int a)
// {
//     return a * a;
// }


// Action<int> printInt = x => System.Console.WriteLine(x);
// printInt(3);

// PrintInt(3);
// static void PrintInt(int x) // Gör samma som line 12
// {
//     System.Console.WriteLine(x);
// }

MultiplyByX(10);

static void MultiplyByX(int x)
{
    for (int i = 0; i <= 10; i++)
    {
        System.Console.WriteLine($"{i}: {x * i}");
    }
}

// Dessa gör samma sak, en skrivs som en vanlig metod och den andra skrivs med lambda expressions.
// Lambda expressions är ett annat sätt att skriva en metod.

PrintResult(x => x * 10, 10);

static void PrintResult(Func<int,int> func, int n)
{
    for (int i = 0; i <= n; i++)
    {
        System.Console.WriteLine($"{i}: {func(i)}");
    }
}

// Func<Person, int, bool> isLegal = (person, legalAge) => person.Age >= legalAge;
// System.Console.WriteLine(isLegal(new Person{Age = 15}, 18));

// class Person
// {
//     public int Age { get; set; }
// }
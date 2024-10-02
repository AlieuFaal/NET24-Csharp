// Miniuppgift 1:

System.Console.WriteLine("Uppgift 1:");
Action<int,int> addDelegate = Add;
addDelegate(3,4);

static void Add(int a, int b)
{
    System.Console.WriteLine(a + b);
}
System.Console.WriteLine();

// Miniuppgift 2:

System.Console.WriteLine("Uppgift 2:");
Func<char, int, string> stringDelegate = GetString;
System.Console.WriteLine(stringDelegate('a',5));

static string GetString(char c, int i)
{
    return new string(c,i);
}

Console.ReadKey();
// DemoDelegate myDelegate = new DemoDelegate(CharCounter);
DemoDelegate myDelegate = CharCounter;

// System.Console.WriteLine(myDelegate.Invoke("Hello World!"));
System.Console.WriteLine(myDelegate("Hello World!"));

myDelegate = WordCounter;

System.Console.WriteLine(myDelegate("Hello World!"));

myDelegate = null;

// Kraschar om myDelegate är null
// System.Console.WriteLine(myDelegate("Hello World!"));

// Kraschar INTE om myDelegate är null
System.Console.WriteLine(myDelegate?.Invoke("Hello World!"));

System.Console.WriteLine();

string[] strings = new string[] {"hello world", "hi there everyone", "denmark"};

ProcessStrings(strings, CharCounter);

System.Console.WriteLine();

ProcessStrings(strings, WordCounter);


System.Console.WriteLine();
System.Console.WriteLine("Multicast Delegates:");

static void FuncA()
{
    System.Console.WriteLine("FuncA");
}

static void FuncB()
{
    System.Console.WriteLine("FuncB");
}

static void FuncC()
{
    System.Console.WriteLine("FuncC");
}
Action action = FuncA;
action += FuncB;
action += FuncC;
action += FuncB;
action += FuncB;
action += FuncA;

action.Invoke();




Console.ReadKey();

static void ProcessStrings(string[] strings, DemoDelegate demoDelegate)
{
    foreach (string s in strings)
    {
        System.Console.WriteLine(demoDelegate?.Invoke(s));
    }
}

static int CharCounter(string text)
{
    return text.Length;
}

static int WordCounter(string text)
{
    return text.Split(' ').Length;
}

static void PrintHello()
{
    System.Console.WriteLine("Hello");
}


public delegate int DemoDelegate(string s);

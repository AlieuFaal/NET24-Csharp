<<<<<<< HEAD
﻿System.Console.WriteLine("****MATH****");

System.Console.WriteLine($"PI = {Math.PI}");
System.Console.WriteLine($"e = {Math.E}");

System.Console.WriteLine($"Math.Abs(5) = {Math.Abs(5)}");
System.Console.WriteLine($"Math.Abs(-5) = {Math.Abs(-5)}");

double value = 4.5;
System.Console.WriteLine($"Math.Floor({value}) = {Math.Floor(value)}"); 
System.Console.WriteLine($"Math.Ceiling({value}) = {Math.Ceiling(value)}"); //Avrundar uppåt
System.Console.WriteLine($"Math.Round({value}) = {Math.Round(value)}"); // Avrundar normalt
System.Console.WriteLine($"Math.Truncate({value}) = {Math.Truncate(value)}"); 

System.Console.WriteLine($"Math.Min(5.23, 6.07) = {Math.Min(5.23, 6.07)}");
System.Console.WriteLine($"Math.Max(5.23, 6.07) = {Math.Max(5.23, 6.07)}");
System.Console.WriteLine($"Math.Clamp(5.23, 6.07, 9.3) = {Math.Clamp(5.23, 6.07, 9.3)}");



// for (int i = 0; i < 5; i++)
// {
//     System.Console.WriteLine($"Math.Max({i}, 5) = {Math.Min(i, 5)}");
// }


for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine($"Math.Clamp({i}, 3, 8) = {Math.Clamp(i, 3, 8)}");
}

System.Console.WriteLine();
System.Console.WriteLine($"Math.Pow(3, 3) = {Math.Pow(3, 3)}");
System.Console.WriteLine($"Math.Sqrt(9) = {Math.Sqrt(9)}");

System.Console.WriteLine("****RANDOM****");

Random rand = new Random(5);

for (int i = 0; i < 10; i++)
{
    // System.Console.WriteLine(rand.Next(1, 10).ToString().PadLeft(30)); Den nedan gör samma sak (alltså att padda)
        System.Console.WriteLine($"{rand.Next(), 12}");

}


=======
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine($"PI = {Math.PI}");
Console.WriteLine($"e = {Math.E}");

Console.WriteLine($"Math.Abs(5) = {Math.Abs(5)}");
Console.WriteLine($"Math.Abs(-5) = {Math.Abs(-5)}");

double value = 5.5;
Console.WriteLine($"Math.Floor({value}) = {Math.Floor(value)}");
Console.WriteLine($"Math.Ceiling({value}) = {Math.Ceiling(value)}");
Console.WriteLine($"Math.Round({value}) = {Math.Round(value)}");
Console.WriteLine($"Math.Truncate({value}) = {Math.Truncate(value)}");

Console.WriteLine($"Math.Min(5.23) = {Math.Min(5.23, 6.07)}");
Console.WriteLine($"Math.Max(5.23) = {Math.Max(5.23, 6.07)}");
Console.WriteLine($"Math.Clamp(5.23, 6.07, 9.3) = {Math.Clamp(5.23, 6.07, 9.3)}");

Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Math.Clamp({i}, 3, 8) = {Math.Clamp(i, 3, 8)}");
}

Console.WriteLine();
Console.WriteLine($"Math.Pow(2, 3) = {Math.Pow(2, 3)}");
Console.WriteLine($"Math.Sqrt(9) = {Math.Sqrt(9)}");

Console.WriteLine();
Console.WriteLine("*** Random ***************");
Console.WriteLine();

Random rand = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{rand.Next(), 12}");
}













>>>>>>> 5078b90a0ec3469ac71d0fb843039ce6ddcbe667

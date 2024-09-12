System.Console.WriteLine("****MATH****");

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



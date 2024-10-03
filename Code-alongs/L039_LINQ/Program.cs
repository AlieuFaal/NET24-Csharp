using Microsoft.VisualBasic;

List <object> objectList= new List<object>();

objectList.Add("Hello");
objectList.Add("World");
objectList.Add(5);
objectList.Add("Hej");
objectList.Add(true);
objectList.Add(3.4);
objectList.Add("Bye!");


//skapa en ny lista och lägg i strängarna från objectList i stringList. Använder foreach. 
List<string> strings = new List<string>();

foreach (object item in objectList)
{
    if (item is string s)
    {
        strings.Add(s);
    }
}

// Skapa en ny lista och lägg in strängarna från objectList i stringList. Använder LINQ.

List<string> stringList2 = objectList.OfType<string>().ToList();
// kan också skrivas som.
// var stringList3 = objectList.OfType<string>().ToList();

Console.WriteLine("stringList2 content:");

Console.WriteLine(string.Join('\n', stringList2));
 
Console.WriteLine();
 
Console.WriteLine($"{"stringList2.Any(s => s.Length == 5)", -50} {stringList2.Any(s => s.Length == 5)}");

Console.WriteLine($"{"stringList2.All(s => s.Length <= 10)", -50} {stringList2.All(s => s.Length <= 10)}");

Console.WriteLine($"{"stringList2.Any(s => s == \"Hej\")", -50} {stringList2.Any(s => s == "Hej")}");

Console.WriteLine($"{"stringList2.Any(s => s.Contains(\"ye\"))", -50} {stringList2.Any(s => s.Contains("ye"))}");

Console.WriteLine($"{"stringList2.Any(s => s.ToLower() == \"hej\")", -50} {stringList2.Any(s => s.ToLower() == "hej")}");

Console.WriteLine($"{"stringList2.Any(s => s.Split(' ').Length == 3)", -50} {stringList2.Any(s => s.Split(' ').Length == 3)}");

Console.WriteLine($"{"stringList2.All(s => s.StartsWith('B'))", -50} {stringList2.All(s => s.StartsWith('B'))}" );

System.Console.WriteLine("\n********************\n");

var stringList3 = stringList2.Where(s => s.Length >= 3 && s.Length <= 7).ToList();
System.Console.WriteLine("stringList3 content:");
System.Console.WriteLine(string.Join('\n', stringList3));

// List<enemy> enemies;
// foreach (var enemy in enemies.Where<enemy>(e => e.HP < 5 && e.name == 'rat'))
// {
        // System.Console.WriteLine(enemy.HP);
// }
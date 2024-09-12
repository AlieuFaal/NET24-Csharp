<<<<<<< HEAD
﻿using System.Net.WebSockets;

System.Console.WriteLine("****STRINGS****");

string myString = string.Empty;

myString = "Hello World!";

System.Console.WriteLine($"Length of my string = {myString.Length}");
System.Console.WriteLine($"myString.ToLower => {myString.ToLower()}");
System.Console.WriteLine($"myString.ToUpper => {myString.ToUpper()}");

System.Console.WriteLine($"myString.PadLeft(50, '*') => {myString.PadLeft(50, '*')}");
System.Console.WriteLine($"myString.PadRight(50, '*') => {myString.PadRight(50, '*')}");


System.Console.WriteLine($"myString.Substring(6) => {myString.Substring(6)}");
System.Console.WriteLine($"myString.Remove(4) => {myString.Remove(4, 2)}");
System.Console.WriteLine($"myString.Insert(4, \"ABC\") => {myString.Insert(6, "ABC")}");


System.Console.WriteLine($"myString.Replace(\"World\", \"there\") => {myString.Replace("World", "there")}");

System.Console.WriteLine($"myString.Replace(\"World\", \"there\") => {myString.IndexOf("World")}");

System.Console.WriteLine();


System.Console.WriteLine("****CHAR****");

System.Console.WriteLine($"Char.IsDigit('A') => {Char.IsDigit('A')}");
System.Console.WriteLine($"Char.IsDigit('4') => {Char.IsDigit('4')}");
System.Console.WriteLine($"Char.IsLetter('A') => {Char.IsLetter('A')}");
System.Console.WriteLine($"Char.IsLetter('4') => {Char.IsLetter('4')}");
System.Console.WriteLine($"Char.IsLetterOrDigit('A') => {Char.IsLetterOrDigit('A')}");
System.Console.WriteLine($"Char.IsLetterOrDigit('4') => {Char.IsLetterOrDigit('4')}");
System.Console.WriteLine($"Char.IsLetterOrDigit('?') => {Char.IsLetterOrDigit('?')}");

foreach (char s in myString)
{
    System.Console.WriteLine($"char.IsUpper('{s}') => {Char.IsUpper(s)}");
=======
﻿Console.WriteLine("*** String ***********");

string myString = string.Empty;

myString = "Hello world!";

Console.WriteLine();
Console.WriteLine($"myString = {myString}");

Console.WriteLine($"Length of myString: {myString.Length}");
Console.WriteLine();

Console.WriteLine($"myString.ToLower() => {myString.ToLower()}");
Console.WriteLine($"myString.ToUpper() => {myString.ToUpper()}");

Console.WriteLine($"myString.PadLeft(50, '*') => {myString.PadLeft(50, '*')}");
Console.WriteLine($"myString.PadRight(50, '*') => {myString.PadRight(50, '*')}");

Console.WriteLine($"myString.Substring(4, 3) => {myString.Substring(4, 3)}");
Console.WriteLine($"myString.Remove(4, 3) => {myString.Remove(4, 3)}");
Console.WriteLine($"myString.Insert(4, \"ABC\") => {myString.Insert(4, "ABC")}");

Console.WriteLine($"myString.Replace(\"world\", \"there\") => {myString.Replace("world", "there")}");

Console.WriteLine($"myString.myString.IndexOf('o')) => {myString.IndexOf('o')}");

Console.WriteLine();
Console.WriteLine("*** Char ************");
Console.WriteLine();

Console.WriteLine($"Char.IsDigit('A') => {Char.IsDigit('A')}");
Console.WriteLine($"Char.IsDigit('4') => {Char.IsDigit('4')}");
Console.WriteLine($"Char.IsLetter('A') => {Char.IsLetter('A')}");
Console.WriteLine($"Char.IsLetter('4') => {Char.IsLetter('4')}");
Console.WriteLine($"Char.IsLetterOrDigit('A') => {Char.IsLetterOrDigit('A')}");
Console.WriteLine($"Char.IsLetterOrDigit('4') => {Char.IsLetterOrDigit('4')}");
Console.WriteLine($"Char.IsLetterOrDigit('?') => {Char.IsLetterOrDigit('?')}");

foreach (char c in myString)
{
    Console.WriteLine($"char.IsUpper('{c}') => {char.IsUpper(c)}");
>>>>>>> 5078b90a0ec3469ac71d0fb843039ce6ddcbe667
}




<<<<<<< HEAD
=======









>>>>>>> 5078b90a0ec3469ac71d0fb843039ce6ddcbe667

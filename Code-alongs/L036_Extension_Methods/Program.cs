using L037_Library;

System.Console.WriteLine("Hello World!".WordCount());

System.Console.WriteLine("Hello World!".Encapsulate("***"));

System.Console.WriteLine("Hello World!".Encapsulate("<<<",">>>"));

// Vi har lagt nedanstående kod i L037 för att visa hur class library projekt fungerar

// static class StringExtensions
// {
//     public static int WordCount(this string s)
//     {
//         return s.Split(' ').Length;
//     }

//     public static string Encapsulate(this string s, string enclosure)
//     {
//         return $"{enclosure} {s} {enclosure}";
//     }

//     public static string Encapsulate(this string s, string enclosureA , string enclosureB)
//     {
//         return $"{enclosureA} {s} {enclosureB}";
//     }
// }




// Console.WriteLine(Directory.GetCurrentDirectory());

// using (StreamWriter writer = new StreamWriter ("myfile.txt", true))
// {
//     for (int i =0; i <= 10; i++)
//     {
//         Console.WriteLine($"Hello {i}");
//         writer.WriteLine($"Hello {i}");
//     }
// }

using (StreamReader reader = new StreamReader("myfile.txt"))
{
    // while (!reader.EndOfStream)
    // {
    //    System.Console.Write((char)reader.Read());

    //    Thread.Sleep(200);
    //    System.Console.WriteLine(reader.ReadLine());
    // }

    System.Console.Write(reader.ReadToEnd());
}



using (FileStream stream = File.OpenRead("L016_FileStream.exe"))
{
    System.Console.WriteLine(stream.Length); 

    byte[] data = new byte[stream.Length];
    stream.Read(data);
}
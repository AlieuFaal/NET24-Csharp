void GetNumbers()
{
    var numbers = new List<int>();
}

foreach (var number in GetNumbers())
{
    System.Console.WriteLine(number);
}

IEnumerable GetNumbers()
{
    for (int i = 0;i < 10; i++)
    {
        yield return i;
    }
}
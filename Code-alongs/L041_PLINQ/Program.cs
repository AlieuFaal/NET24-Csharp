﻿

var list = Enumerable
    .Range(0,50)
    .AsParallel()
    .Select(i => CostlyOperation(i))
    .ToList();

System.Console.WriteLine("\nProcessing complete! Here is the processed data: \n");
list.ForEach(i => System.Console.WriteLine(i));

static int CostlyOperation(int n)
{
    // for (int i = 0;i < 1000_000_000; i++);
    
    Thread.Sleep(1000);
    System.Console.WriteLine($"Processing element {n}.");
    return n;
}
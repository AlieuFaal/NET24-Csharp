
Task<int> task1 = Task.Run (() =>
{
    int sum = 0;

    for (int i = 0;i < 1000; i++)
    {
        sum += i;
    }
    
    return sum;
});

task1.Status 

Task task2 = Task.Run (() =>
{
    for (int i = 0;i < 1000; i++)
    {
        Console.Write($"B");
    }
});

// for (int i = 0;i < 1000; i++)
// {
//     Console.WriteLine($"Main thread: {i}");
// }

System.Console.WriteLine("Main thread continues ...");

// Task.WaitAll(task1, task2);

System.Console.WriteLine($"The result of task1: {task1.Result}");

System.Console.WriteLine("The end!");

// static void Task1()
// {
//     for (int i = 0;i < 2000; i++)
//     {
//         Console.WriteLine($"Task1: {i}");
//     }
// }
System.Console.WriteLine("****DateTime****");
System.Console.WriteLine();

System.Console.WriteLine($"DateTime.MinValue => {DateTime.MinValue}");
System.Console.WriteLine($"DateTime.MaxValue => {DateTime.MaxValue}");
System.Console.WriteLine($"DateTime.UtcNow => {DateTime.UtcNow}");
System.Console.WriteLine($"DateTime.UtcNow => {DateTime.Now}");
System.Console.WriteLine($"DateTime.UtcNow => {DateTime.Today}");

System.Console.WriteLine();

DateTime myDateTime = new DateTime(2019,10,3,13,12,15);
System.Console.WriteLine($"myDateTime = {myDateTime}");
System.Console.WriteLine();

System.Console.WriteLine($"myDateTime.Year = {myDateTime.Year}");
System.Console.WriteLine($"myDateTime.Month = {myDateTime.Month}");
System.Console.WriteLine($"myDateTime.Day = {myDateTime.Day}");
System.Console.WriteLine($"myDateTime.Hour = {myDateTime.Hour}");
System.Console.WriteLine($"myDateTime.Minute = {myDateTime.Minute}");
System.Console.WriteLine($"myDateTime.Second = {myDateTime.Second}");
System.Console.WriteLine($"myDateTime.DayOfWeek = {myDateTime.DayOfWeek}");
System.Console.WriteLine($"myDateTime.DayOfYear = {myDateTime.DayOfYear}");

System.Console.WriteLine($"myDateTime.AddYears(5) = {myDateTime.AddYears(5)}");
System.Console.WriteLine($"myDateTime.AddMinutes(10) = {myDateTime.AddMinutes(10)}");

myDateTime = myDateTime.AddYears(5).AddMonths(3).AddHours(5);
System.Console.WriteLine();
System.Console.WriteLine($"myDateTime = {myDateTime}");

TimeSpan myTimeSpan = new TimeSpan(10, 4, 3);
System.Console.WriteLine($"myTimeSpan = {myTimeSpan}");

System.Console.WriteLine($"myDateTime.Now) = {DateTime.Now}");

System.Console.WriteLine($"myDateTime.Subtract(DateTime.Now) = {myDateTime.Subtract(DateTime.Now)}");













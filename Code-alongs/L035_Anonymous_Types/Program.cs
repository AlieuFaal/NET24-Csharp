using System.ComponentModel;
using System.Net.Mail;

var person1 = new {FirstName = "Kalle", LastName = "Andersson", Age = 33};

var data = new {Integer = 1, Float = 2.0f, Double = 3.0, Decimal = 4.0M, Long = 5L, Bool = true };

var People = new[]
{
    new {FirstName = "Kalle", LastName = "Andersson", Age = 14},
    new {FirstName = "Lisa", LastName = "Palm", Age = 34},
    new {FirstName = "Per", LastName = "Andersson", Age = 33},
    new {FirstName = "Anna", LastName = "Lundberg", Age = 24},
    new {FirstName = "Camilla", LastName = "Eriksson", Age = 67}
};

var people2 = People.Select(person => new {FirstName = person.FirstName, Age = person.Age * 2}).ToList();

System.Console.WriteLine();
// foreach (var person in People)
// {
//     System.Console.WriteLine($"{person.FirstName} is {person.Age} years old.");
// }

// var person2 = new
// {
//     name = "Anders Eriksson",
//     age = 45,
//     contactInfo = "email = anders.eriksson@hotmail phoneNr = 0723853923"
// };

// System.Console.WriteLine();

// System.Console.WriteLine(person1);

// System.Console.WriteLine();

// System.Console.WriteLine(person1.FirstName);

// System.Console.WriteLine();

// System.Console.WriteLine(data);

// System.Console.WriteLine();

// System.Console.WriteLine(data.Integer);

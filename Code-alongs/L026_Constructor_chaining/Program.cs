var myHuman = new Human() { FirstName = "Alieu", LastName = "Faal", Title = "Mr. " };

Console.ReadKey();

class Human
{
    public string FirstName { get; set; }

    public string LastName { get; set;}

    public string Title { get; set; }

    public Human()
    {

    }

    public Human(string firstName, string lastName, string title) : this(firstName, lastName)
    {
        Title = title;
    }

    public Human (string firstName, string lastName) : this (lastName)
    {
        FirstName = firstName;
    }

    public Human (string firstName)
    {
        FirstName = firstName;
    }
}

class Student : Human
{
    public double Grade { get; set; }

    public Student (string FirstName, string LastName, string Title, double grade) : 
        base(FirstName, LastName, Title)
    {
        Grade = grade;
    }
}

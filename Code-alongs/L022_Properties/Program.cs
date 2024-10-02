Otter otter1 = new();

// otter1.SetName("Allan");
// Console.WriteLine(otter1.GetName());

// otter1.name = "Allan";

otter1.Name = "Kalle";
otter1.Age = 15;
System.Console.WriteLine(otter1.Name);

class Otter
{
    private string _name = "Otto";

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            // if (value.ToLower() == "kalle")
            // {
            //     throw new ArgumentException("Invalid otter name '{value}'");
            // }
            _name = value;
        }
    }

    private int _age; 

    public int Age 
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }


    // public void SetName(string _name)
    // {
    //     this._name = _name;
    // }

    // public string GetName()
    // {
    //     return _name;
    // }
}

class Subscriber
{
    private string name;

    public Subscriber(string name)
    {
        this.name = name;
    }

    public void OnMessageReceived(object sender, EventArgs eventArgs)
    {
        System.Console.WriteLine($"{name} got the message: {args.message}!");
    }
}
// var streamReader = new StreamReader("myfile.txt"));

using (var dog = new Dog())
{
    //läs fil, etc...

}


class Dog : IDisposable
{
    public void IDispose()
    {
        System.Console.WriteLine("Disposed");
    }
}
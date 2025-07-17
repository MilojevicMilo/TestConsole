public class A
{
    public void MethodA()
    {
        Console.WriteLine("Method A");
    }

    public A(string name)
    {
        Console.WriteLine($"Constructor A called with name: {name}");
        Name = name;
    }
    public string Name { get;}
}
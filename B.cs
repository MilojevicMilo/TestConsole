public class B
{
    public void MethodB()
    {
        Console.WriteLine("Method B");
    }

    public B(string name)
    {
        Console.WriteLine($"Constructor B called with name: {name}");
        Name = name + "B";
    }
    public string Name { get;}
}

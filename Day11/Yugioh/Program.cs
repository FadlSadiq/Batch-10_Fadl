using System.Reflection;

public class ObjectA
{
    public ObjectB B;

    ~ObjectA()
    {
        // Accessing B property in finalizer
        Console.WriteLine(B.Value);
    }
}

public class ObjectB
{
    public int Value;

    ~ObjectB()
    {
        // Setting Value property to 0 in finalizer
        Value = 0;
    }
}

class Program
{
    static void Main()
    {
    var a = new ObjectA();
    a.B = new ObjectB();
    a.B.Value = 5;
    a = null;
    GC.Collect();

    }
}
class Program
{
    static void Main()
    {
        Garbage squid = new();
        squid.Greeting();
        GC.Collect();
    }
}

class Garbage
{
    public void Greeting()
    {
        System.Console.WriteLine("Hello Squidward");
    }
}

class 
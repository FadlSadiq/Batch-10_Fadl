class Program
{
    static void Main()
    {
        MyDelegate my = new MyDelegate(Print);
        my += Run;
        my.Invoke();
    }


    public delegate void MyDelegate();

    static void Print()
    { 
        Console.WriteLine("nice");
    }

    static void Run()
    {
        Console.WriteLine("AAAA");
    }
}
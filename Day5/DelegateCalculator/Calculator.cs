public delegate void Operation(int x, int y);

public class Calculator()
{
    public static void Multiply(int x, int y)
    {
        Console.WriteLine(x * y);
    }
    public static void Add(int x, int y)
    {
        Console.WriteLine(x + y);
    }
}
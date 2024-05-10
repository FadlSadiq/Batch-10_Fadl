using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        int x = 3, y = 5;
        Swapper.Swap<int>(ref x , ref y);
        Console.WriteLine(x);
    }
}

class Swapper
{
    public static void Swap<T>(ref T x, ref T y)
    {
        T swap = x;
        x = y;
        y = swap;
    }
}
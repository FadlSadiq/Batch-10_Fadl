public class Program
{
    static void Main()
    {
        FooBar n = new FooBar(5);
        System.Console.WriteLine(n);
    }

}

public class FooBar
{
    public int n;
    public FooBar(int n)
    {
        this.n = n;
    }
    public static IEnumerable<int> GetNumbers(int n)
    {
        for(int i = 0; i <= n; i++)
        {
            yield return i; 
        }

    }
}


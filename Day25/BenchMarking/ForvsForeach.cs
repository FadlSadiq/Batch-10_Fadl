using BenchmarkDotNet.Attributes;

public class ForvsForeach
{
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    [Benchmark]
    public int MyFor()
    {
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += i;
        }
        return sum;
    }
    [Benchmark]
    public int MyForEach()
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
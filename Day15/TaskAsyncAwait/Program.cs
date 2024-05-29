class Program
{
    static async Task Main()
    {
        int res = await Add(2,3);
        System.Console.WriteLine(res);
    }

    static async Task<int> Add(int a, int b)
    {
        int result = await Task.FromResult(a+b);
        return result;
    }
}
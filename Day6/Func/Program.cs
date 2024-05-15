class Program
{
    static void Main()
    {
        // Func<int, int, int, int> addition = AddNumbers;
        // Console.WriteLine(addition(2,3,4));
        Action<int, int> Addition2 = AddNumbers;
        Addition2(2,5);
    }
    // private static int AddNumbers(int parameter1, int parameter2, int parameter3)
    // {
    //     return parameter1 + parameter2 + parameter3
    // }

    private static void AddNumbers(int pr, int pr2)
    {
        int result = pr + pr2;
        Console.WriteLine(result);
    }
}
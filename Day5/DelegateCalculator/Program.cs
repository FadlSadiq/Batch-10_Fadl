class Program
{
    static void Main()
    {
        Operation operate = Calculator.Add;
        operate += Calculator.Multiply;
        operate.Invoke(2,3);
    }
}
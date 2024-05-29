class Program
{
    static void Main()
    {
        try
        {
            Task task = Task.Run(()=>ExceptionMaker());
            Task task2 = Task.Run(()=>ExceptionMaker2());
            Task.WaitAll(task, task2);
        }
        catch(AggregateException e) // handling exception terpusat, hanya dimiliki task
        {
            System.Console.WriteLine(e.Message);
        }
    }
    static void ExceptionMaker()
    {
        throw new FormatException("Exception thrown from ExceptionMaker");
    }

    static void ExceptionMaker2()
    {
        throw new FormatException("Exception thrown from ExceptionMaker2");
    }
}
class Program
{
    static void Main()
    {
        Task task = Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine("+");
                Thread.Sleep(5);
            }
        });

        Console.WriteLine(task.IsCompleted);
        System.Console.WriteLine(task.IsCanceled);
        System.Console.WriteLine(task.IsFaulted);

        Task.WaitAll(task);
        Console.WriteLine(task.IsCompleted);
        System.Console.WriteLine(task.IsCanceled);
        System.Console.WriteLine(task.IsFaulted);
    }
}
class Program
{
    static void Main()
    {
        Task task1 = new Task(() =>
        {
            System.Console.WriteLine("T1");
            Thread.Sleep(6000);
            System.Console.WriteLine("Task 1 Complete");
        });

        Task task2 = new Task(() =>
        {
            System.Console.WriteLine("T2");
            Thread.Sleep(5000);
            System.Console.WriteLine("Task 2 Complete");
        });
        task1.Start();
        task2.Start();

        System.Console.WriteLine("Task 1 Running");
        System.Console.WriteLine("Task 2 Running");

        task1.Wait();
        System.Console.WriteLine("Task 1 Done");
        task2.Wait();
    }
}
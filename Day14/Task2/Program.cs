class Program
{
    static void Main()
    {
        Task opening = new Task(() =>
        {
            System.Console.WriteLine("Welcome to Auto Chess");
        });

        Task menu = new Task(() =>
        {
            
            Thread.Sleep(5000);
            System.Console.WriteLine("Please choose your mode\n");
        });

        opening.Start();
        menu.Start();

        Task.WaitAll(opening, menu);
        System.Console.WriteLine("all complete");

    }
}
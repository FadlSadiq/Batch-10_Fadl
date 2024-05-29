class Autoreset
{
    static AutoResetEvent autoResetEvent = new AutoResetEvent(true);
    static void Main()
    {
        Thread thread = new Thread(SomeMethod)
        {
            Name = "Snoopy"
        };
        Thread thread2 = new Thread(SomeMethod)
        {
            Name = "Blue"
        };
        thread.Start();
        thread2.Start();

        Console.ReadLine();
    }
    static void SomeMethod()
    {
        autoResetEvent.WaitOne();
        System.Console.WriteLine("Starting...");
        System.Console.WriteLine(Thread.CurrentThread.Name);
        Thread.Sleep(2000);
        System.Console.WriteLine("Finished..");
        System.Console.WriteLine(Thread.CurrentThread.Name);
        autoResetEvent.Set();
    }
}
class Program
{
    static async void Main()
    {
        await Synchronous();
        // await Asynchronous();
    }

    // static async void Synchronous()
    static async Task Synchronous()
    {
        DoWork("mandi");
        DoWork("sholat");
        await Asynchronous();
        DoWork("tidur");
    }

    static async Task Asynchronous()
    {
        Task eat = DoWorkAsync("eat");
        Task drink = DoWorkAsync("drink");

        await Task.WhenAll(eat, drink);
    }

    static void DoWork(string work)
    {
        System.Console.WriteLine($"{work} is started");
        Thread.Sleep(2000);
        System.Console.WriteLine($"{work} is finished");
    }

    static async Task DoWorkAsync(string work)
    {
        System.Console.WriteLine($"{work} is started");
        await Task.Delay(2000);
        System.Console.WriteLine($"{work} is finished");
    }
}
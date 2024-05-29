class Program
{
    static void Main()
    {
        Thread thread = new Thread(()=>
        {
            try
            {
                Thread.Sleep(1000);
                throw new Exception("Error");
            }
            catch(Exception e)
            {
                System.Console.WriteLine($"Exception caught: {e.Message}");
            }
        });

        thread.Start();
        System.Console.WriteLine("Finished");
    }
}
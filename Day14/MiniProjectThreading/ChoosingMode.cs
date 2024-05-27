public class ChoosingMode
{
    public void Choosing()
    {
        Thread.Sleep(400);
        System.Console.WriteLine("Pick your Mode\n - Play \n - Quit");
        string input = Console.ReadLine();
        System.Console.WriteLine($"{input}");
    }
}
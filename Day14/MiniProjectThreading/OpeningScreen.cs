public class OpeningScreen
{
    public void started()
    {
        string opening = "Click Enter to Join the Game";
        for (int i = 0; i < opening.Length; i++)
        {
            Console.Write($"{opening[i]}");
            Thread.Sleep(TimeSpan.FromSeconds(0.1));
        }
        Console.ReadKey(true);
        System.Console.WriteLine($"\nWelcome to AutoChess");
    }
}
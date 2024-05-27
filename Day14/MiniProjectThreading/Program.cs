class Program
{
    static void Main()
    {
        Console.WriteLine("Saya bendera putih, kamu bendera merah");
        OpeningScreen openingScreen = new();
        // TutorialDecision tutorialDecision = new();
        // ChoosingMode choosingMode = new();
        Task one = new(openingScreen.started);
        one.Start();
        one.Wait();
        System.Console.WriteLine("Please insert your name: ");
        string name = Console.ReadLine();
        System.Console.WriteLine($"Hello {name}, do you want to do the tutorial? yes/no");
        string decision = Console.ReadLine();
        // tutorialDecision.Decision(decision);

        
        
        // Task two = new(choosingMode.Choosing);
        // Thread three = new Thread();

        
        // two.Start();
        
        // two.Wait();
    }
}
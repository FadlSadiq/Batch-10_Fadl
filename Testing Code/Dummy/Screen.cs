using static System.Console;
public class Screen
{
    public void Start()
    {
        Title = "AUTO CHESS";
        RunMainMenu();


        // System.Console.WriteLine("Press any key to exit...");
        // Console.ReadKey(true);
    }
    private void RunMainMenu()
    {
        string prompt = "Welcome to Auto Chess, what do you want to do?";
        string[] options = { "Play", "Tutorial", "Exit" };
        Menu mainMenu = new(prompt, options);
        int selectedIndex = mainMenu.Run();

        switch (selectedIndex)
        {
            case 0:
                RunFirstChoice();
                break;
            case 1:
                Tutorial();
                break;
            case 2:
                ExitGame();
                break;

        }
    }
    private void ExitGame()
    {
        System.Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey(true);
        Environment.Exit(0);
    }
    private void Tutorial()
    {
        Clear();
        System.Console.WriteLine("Created by Fadl");
        Console.ReadKey(true);
        RunMainMenu();


    }
    private void RunFirstChoice()
    {
        System.Console.WriteLine("Welcome to the game");
    }
}
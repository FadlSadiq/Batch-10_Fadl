using static System.Console;
using Controller;

class Program
{
    static void Main()
    {
        Start();
    }

    public static void Start()
    {
        Title = "AUTO CHESS";
        RunMainMenu();
    }

    internal static void RunMainMenu()
    {
        string prompt = "Welcome to Auto Chess, what do you want to do?";
        string[] options = { "Play", "Tutorial", "Exit" };
        Program mainMenu = new(prompt, options);
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

    private static void ExitGame()
    {
        WriteLine("\nPress any key to exit...");
        ReadKey(true);
        Environment.Exit(0);
    }

    private static void Tutorial()
    {
        Clear();
        WriteLine("Created by Fadl");
        ReadKey(true);
        RunMainMenu();
    }

    private static void RunFirstChoice()
    {
        CommunityPool compoll = new();
        compoll.OpenCommunityPool(GameState.Preparation);
    }

    private int SelectedIndex;
    private string[] Options;
    private string Prompt;

    public Program(string prompt, string[] options)
    {
        Prompt = prompt;
        Options = options;
        SelectedIndex = 0;
    }

    private void DisplayOptions()
    {
        WriteLine(Prompt);
        for (int i = 0; i < Options.Length; i++)
        {
            string currentOption = Options[i];
            string prefix;

            if (i == SelectedIndex)
            {
                prefix = ">";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                prefix = " ";
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Black;
            }
            WriteLine($"{prefix} << {currentOption} >>");
        }
        ResetColor();
    }

    public int Run()
    {
        ConsoleKey keyPressed;
        do
        {
            Clear();
            DisplayOptions();
            ConsoleKeyInfo keyInfo = ReadKey(true);
            keyPressed = keyInfo.Key;

            // Update SelectionIndex based on arrow keys
            if (keyPressed == ConsoleKey.UpArrow)
            {
                SelectedIndex--;
                if (SelectedIndex == -1)
                {
                    SelectedIndex = Options.Length - 1;
                }
            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                SelectedIndex++;
                if (SelectedIndex == Options.Length)
                {
                    SelectedIndex = 0;
                }
            }
        }
        while (keyPressed != ConsoleKey.Enter);
        return SelectedIndex;
    }
}
using static System.Console;
using Controller;
using Microsoft.VisualBasic;

class Program
{
    private static GameController _game;
    static void Main()
    {
        List<Position> benchPosition = new List<Position>();
        for (int i = 0; i < 10; i++)
        {
            benchPosition.Add(new Position(i, 0));
        }
        List<Position> arenaPosition = new List<Position>();
        for (int y = 1; y < 10; y++)
        {

        }

        _game = new GameController
        (new Arena(),
        new Bench(benchPosition),
        GameState.NonInitialized
        );
        Start(); ;
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
        System.Console.WriteLine("How Many Player are Playing? max 8");
        int ActivePlayer = Convert.ToInt32(Console.ReadLine());
        _game.SetActivePlayer(ActivePlayer);
        MenuBattle();
    }
    private static void MenuBattle()
    {
        CommunityPool compoll = new();
        compoll.OpenCommunityPool(GameState.Preparation);
        _game.SetGameState(GameState.Preparation);
        string prompt = "Welcome to Auto Chess, what do you want to do?";
        string[] options = { "Arena", "Bench", "Shop", "Backpack", "Level Up", "Exit" };
        var mainMenu = new Program(prompt, options);
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
                Shop();
                break;
        }
    }

    private static void Shop()
    {
        _game.GenerateHeroesOnStore(_game.GameState);
        Dictionary<string, List<HeroData>> heroPair = _game.GenerateHeroesOnStore(_game.GameState);
        string prompt = "Available Heroes:\n---------------------------------- \n| Hero Name      | Rarity | Price |";
        string [] options = new string[5];
        int indexArray = 0;
        foreach (var hero in heroPair)
        {
            int i = 0;
            foreach (var value in hero.Value)
            {
                if (i == 0)
                {
                    Console.WriteLine($"| {hero.Key,-16} | {value.HeroLevel,-5} | {value.HeroRarity,-8} | {value.HeroPrice,-5} |");
                    options[indexArray] = hero.Key;
                    indexArray++;
                }
                i++;
            }
        }
        //Display hero data in a table-like format
        var mainMenu = new Program(prompt, options);
        int selectedIndex = mainMenu.Run();
        switch (selectedIndex)
        {
            case 0:
                //_game.OnPurchaseHero(options[0]);
                MenuBattle();
                break;
            case 1:
                MenuBattle();
                break;
            case 2:
                MenuBattle();
                break;
            case 3:
                MenuBattle();
                break;
            case 4:
                MenuBattle();
                break;
        }

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
using static System.Console;
public class Menu
{
    private int SelectedIndex;
    private string[] Options;
    private string Prompt;
    public Menu(string prompt, string[] options)
    {
        Prompt = prompt;
        Options = options;
        SelectedIndex = 0;
    }

    private void DisplayOptions()
    {
        System.Console.WriteLine(Prompt);
        for (int i = 0; i < Options.Length; i++)
        {
            string currentOption = Options[i];
            string prefix;

            if(i == SelectedIndex)
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
            System.Console.WriteLine($"{prefix}<< {currentOption} >>");
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
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            keyPressed = keyInfo.Key;

            //Update SelectionIndex based on arrow keys
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
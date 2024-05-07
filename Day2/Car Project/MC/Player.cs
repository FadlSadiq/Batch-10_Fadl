using Monster;
namespace MC;

public class Player
{
    public string playerName;
    public int playerLevel;
    public Armor armor;
    public Weapon weapon;
    public Slime slime;


    public Player(string name, int level)
    {
        playerName = name;
        playerLevel = level;
    }

    public int PlayerAttribute(int playerLevel)
    {
        playerLevel += 1;
        return playerLevel;
    }
    public void PlayerAttribute(string playerName, int playerLevel)
    {
        playerLevel += 1;
        Console.WriteLine($"I am {playerName}, level {playerLevel}");
    }


}
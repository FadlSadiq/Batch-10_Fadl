using ClassGame;

public class Program
{
    static void Main()
    {
        Warrior warrior = new("sword", "armor", "duel");
        Magician magician = new("Staff", "robe", "synthesize");
        magician.Pick();
        warrior.Pick();
    }
}
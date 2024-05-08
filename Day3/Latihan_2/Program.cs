using Monster;

class Program
{
    static void Main()
    {
        Goblin gob = new();
        gob.Dimension(120, 16);
        gob.Skill("Smash");
        HobGoblin hob = new();
        hob.Colour();
        hob.ChangeColour("square");
        Slime sli = new();
        sli.Dimension(50, 40);
        sli.Skill("Digest");
        Darkslime darky = new();
        darky.Colour();
    }
}
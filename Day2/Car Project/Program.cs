using MC;
using Monster;
using NPC;

class Program
{
    static void Main()
    {
        Player raze = new Player("Raze", 1);
        Weapon flute = new Weapon("Horn", 8, "Fire");
        Armor steel = new Armor("Gem", 15);
        Merlin Wwizard = new Merlin("Merlin", "Mondstat");
        Slime gloo = new Slime("gloo", 1, 15, 6);

        raze.PlayerAttribute(raze.playerName,raze.playerLevel);
        gloo.SlimeChar(gloo.levelSlime, gloo.healthSlime, gloo.damageSlime);
    }
}
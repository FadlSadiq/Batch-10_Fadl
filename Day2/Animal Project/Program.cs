using CharacterClass;

class Program
{
    static void Main()
    {
        JobClass pick = new("weapon", "armor", "accessories");
        WarriorClass Tiny = new WarriorClass("Sword", "Steel", "Helmet", "Bow");
        CraftmanClass Gargol = new CraftmanClass("Hammer", "Iron", "Anvil", "Upgrade");
        MagicianClass Ivy = new MagicianClass("Staff", "Silk", "ring", "Fireball");
        
        Console.WriteLine("Pick your Class");
        Tiny.Hunting(Tiny.weapon, Tiny.armor, Tiny.accessories, Tiny.hunt);
        Gargol.Crafting(Gargol.weapon, Gargol.armor, Gargol.accessories, Gargol.craft);
        Ivy.Synthesizing(Ivy.weapon, Ivy.armor, Ivy.accessories, Ivy.Synthesize);
    }
}
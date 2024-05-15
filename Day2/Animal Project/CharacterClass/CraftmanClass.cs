namespace CharacterClass;

public class CraftmanClass : JobClass
{
    public string craft;

    public CraftmanClass(string weapon, string armor, string accessories, string craft) : base(weapon, armor, accessories)
    {
        this.weapon = weapon;
        this.armor = armor;
        this.accessories = accessories;
        this.craft = craft;
    }

    public void Crafting(string weapon, string armor, string accessories, string craft)
    {
        Console.WriteLine($"This is Craftman status: weapon {weapon}, armor {armor}, accessories {accessories}, skill {craft}");
    }
}

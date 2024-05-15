namespace CharacterClass;

public class WarriorClass : JobClass
{
    public string hunt;

    public WarriorClass(string weapon, string armor, string accessories, string hunt) : base(weapon, armor, accessories)
    {
        this.weapon = weapon;
        this.armor = armor;
        this.accessories = accessories;
        this.hunt = hunt;
    }

    public void Hunting(string weapon, string armor, string accessories, string hunt)
    {
        Console.WriteLine($"This is Warrior status: weapon {weapon}, armor {armor}, accessories {accessories}, skill {hunt}");
    }
}

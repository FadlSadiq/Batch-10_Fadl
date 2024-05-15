namespace CharacterClass;

public class MagicianClass : JobClass
{
    public string Synthesize;

    public MagicianClass(string weapon, string armor, string accessories, string Synthesize) : base(weapon, armor, accessories)
    {
        this.weapon = weapon;
        this.armor = armor;
        this.accessories = accessories;
        this.Synthesize = Synthesize;
    }

    public void Synthesizing(string weapon, string armor, string accessories, string Synthesize)
    {
        Console.WriteLine($"This is Magician status: weapon {weapon}, armor {armor}, accessories {accessories}, skill {Synthesize}");
    }
}

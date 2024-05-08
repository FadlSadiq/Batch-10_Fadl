namespace ClassGame;

public class Magician : Job
{
    public string skill;
    public Magician(string weapon, string armor, string skill) : base(weapon, armor)
    {
        this.weapon = weapon;
        this.armor = armor;
        this.skill = skill;
    }
    public override void Pick()
    {
        base.Pick();
        Console.WriteLine($"Magician weapon is {weapon}, armor is {armor} and skill is {skill}");
    }
}
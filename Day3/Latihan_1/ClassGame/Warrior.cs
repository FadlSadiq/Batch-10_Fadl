namespace ClassGame;

public class Warrior : Job
{
    public string skill;
    public Warrior(string weapon, string armor, string skill) : base(weapon, armor)
    {
        this.weapon = weapon;
        this.armor = armor;
        this.skill = skill;
    }
    public override void Pick()
    {
        base.Pick();
        Console.WriteLine($"Warrior weapon is {weapon}, armor is {armor} and skill is {skill}");
    }
}
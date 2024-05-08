namespace ClassGame;

public class Job
{
    public string weapon;
    public string armor;

    public Job(string weapon, string armor)
    {
        this.weapon = weapon;
        this.armor = armor;
    }
    public virtual void Pick()
    {
        Console.WriteLine("Choose your Character");
    }
}
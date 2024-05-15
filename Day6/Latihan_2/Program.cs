using System.Runtime.CompilerServices;

public class HealthCondition
{
    public int Health{get; set;}
    public int Damage{get; set;}
    public HealthCondition(int newHealth, int damage)
    {
        Health = newHealth;
        Damage = damage;
    }
    public static HealthCondition operator -(HealthCondition h1, HealthCondition d1)
    {
        int newHealth = h1.Health - d1.Damage;
        int newDamage = d1.Damage;
        HealthCondition hp = new(newHealth, newDamage);
        return hp;
    }
}

class Program
{
    static void Main()
    {
        HealthCondition Char = new(7,3);
        HealthCondition Monster = new(4,2);
        HealthCondition newChar = Char - Monster;
        Console.WriteLine(newChar.Health);
    }
}
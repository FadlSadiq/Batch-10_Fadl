namespace Monster;

public class Slime
{
    public string nameSlime;
    public int levelSlime;
    public int healthSlime;
    public int damageSlime;

    public Slime(string name, int level, int health, int damage)
    {
        nameSlime = name;
        levelSlime = level;
        healthSlime = health;
        damageSlime = damage;
    }

    public void SlimeChar(string nameSlime)
    {
        Console.WriteLine($"I am {nameSlime}");
    }

    public void SlimeChar(int levelSlime, int healthSlime, int damageSlime)
    {
        levelSlime += 1;
        damageSlime += 3;
        healthSlime += 20;
        Console.WriteLine($"New Status : level {levelSlime}, damage {damageSlime}, health {healthSlime}");

    }
}
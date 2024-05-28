class Program
{
    static void Main()
    {
        int AttackA = 120;
        int HealthPointA = 3000;
        Damaged damage = new();
        System.Console.WriteLine(damage.Damage(AttackA, HealthPointA));

    }
}

class Damaged
{
    public int Damage(int AttackA, int HealthPointA)
    {
        return HealthPointA -= AttackA;
    }
}
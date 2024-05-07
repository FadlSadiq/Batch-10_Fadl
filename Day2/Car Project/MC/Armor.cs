namespace MC;

public class Armor
{
    public string armorName;
    public int armorDefense;

    public Armor(string armorName, int armorDefense)
    {
        this.armorName = armorName;
        this.armorDefense = armorDefense;
    }

    public void ArmorAttribute(string armorName, string armorDefense)
    {
        Console.WriteLine($"This is {armorName}, it has {armorDefense} defense.");
    }
}
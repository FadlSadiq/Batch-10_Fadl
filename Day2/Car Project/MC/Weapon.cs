using Monster;
namespace MC;

public class Weapon
{
    public string weaponName;
    public int weaponDmg;
    public string weaponElement;
    public Slime healthSlime;

    public Weapon(
        string name, 
        int dmg, 
        string element)
    {
        weaponName = name;
        weaponDmg = dmg;
        weaponElement = element;
    }

    public void WeaponAttribute(
        string weaponName,
        int weaponDmg, 
        string weaponElement)
    {
        Console.WriteLine($"The name of this sword is {weaponName}, the damage is {weaponDmg} and has an element of {weaponElement}");
    }
}
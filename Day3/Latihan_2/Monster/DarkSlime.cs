namespace Monster;

public class Darkslime : Body, ICharacter
{
    public void Dimension(int height, int width)
    {
        Console.WriteLine($"The dimension for goblin is " + height * width);
    }
    public void Skill(string skill)
    {
        Console.WriteLine($"The skill for goblin is {skill}");
    }
    public override void Colour(string colour)
    {
        Console.WriteLine($"This monster colour is {colour}");
    }
    public override void ChangeShape(string shape)
    {
        Console.WriteLine($"This monster shape is {shape}");
    }
}
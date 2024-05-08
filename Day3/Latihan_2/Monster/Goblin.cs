namespace Monster;

public class Goblin : ICharacter
{
    public void Dimension(int height, int width)
    {
        Console.WriteLine($"The dimension for goblin is " + height * width);
    }
    public void Skill(string skill)
    {
        Console.WriteLine($"The skill for goblin is {skill}");
    }
}
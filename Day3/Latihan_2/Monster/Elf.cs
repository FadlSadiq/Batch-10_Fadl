namespace Monster;

public class Elf : Body, ICharacter, IStyle, IMovement
{
    public override void Colour(string colour)
    {
        Console.WriteLine($"the Elf colour is " + colour);
    }
    public void Dimension(int height, int width)
    {
        Console.WriteLine($"The dimension for goblin is " + height * width);
    }
    public void Skill(string skill)
    {
        Console.WriteLine($"The skill for elf is {skill}");
    }
    public void Costume(string costume)
    {
        Console.WriteLine($"The elf is wearing {costume}");
    }
    public void Gender(string gender)
    {
        Console.WriteLine($"The elf gender is {gender}");
    }
    public void Movement(int x_Axis, int y_Axis, int z_Axis)
    {
        Console.WriteLine($"The coordinate for the elf is {x_Axis}, {y_Axis}, {z_Axis}");
    }
}
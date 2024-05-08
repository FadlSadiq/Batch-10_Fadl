namespace Monster;

public class HobGoblin : Body
{
    public override void Colour(string colour)
    {
        Console.WriteLine($"This monster colour is {colour}");
    }
    public override void ChangeShape(string shape)
    {
        Console.WriteLine($"This monster shape is {shape}");
    }
}
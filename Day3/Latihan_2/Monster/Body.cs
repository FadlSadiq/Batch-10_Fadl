namespace Monster;

public abstract class Body
{
    public abstract void Colour(string colour);
    public virtual void ChangeShape(string shape)
    {
        Console.WriteLine("This monster shape is square");
    }
}
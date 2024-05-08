namespace Monster;

public abstract class Body
{
    public abstract void Colour();
    public virtual void ChangeColour(string Color)
    {
        Console.WriteLine("This monster colour is " + Color);
    }
}
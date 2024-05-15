public class Box
{
    public int Length {get; set;}
    public int Width {get; set;}
    public Box(int length, int width)
    {
        Length = length;
        Width = width;
    }
    public static Box operator +(Box b1, Box b2)
    {
        int length = b1.Length + b2.Length;
        int width = b1.Width + b2.Width;
        Box box = new Box(length, width);
        return box;
    }
}

class Program
{
    public static void Main()
    {
        Box box1 = new(4,4);
        Box box2 = new(7,5);
        Box box3 = box1 + box2;
        Console.WriteLine(box3.Length);
        Console.WriteLine(box3.Width);
    }
}
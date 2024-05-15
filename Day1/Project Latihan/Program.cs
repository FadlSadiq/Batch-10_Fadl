class Laptop
{
    public string brand = "acer";
    public string type = "Swift 3";
    public string colour = "red";
    public string temperature = "40 degrees";
    public string price = "Rp. x.xxx.xxx";

    public void Processing()
    {
        Console.WriteLine("Laptop is Processing right now");
    }
    public void Loading()
    {
        Console.WriteLine("Laptop is Loading for the screen");
    }
    public void Editing()
    {
        Console.WriteLine("Laptop can be used for Editing");
    }
    public void Operating()
    {
        Console.WriteLine("Laptop is Operating right now");
    }
    public void Training()
    {
        Console.WriteLine("Laptop used for training Data");
    }
}

class Program
{
    static void Main()
    {
        Laptop acer = new Laptop();
        acer.Processing();
        acer.Loading();
        acer.Editing();
        acer.Operating();
        acer.Training();
        Console.WriteLine(acer.brand);
        Console.WriteLine(acer.type);
        Console.WriteLine(acer.colour);
        Console.WriteLine(acer.temperature);
        Console.WriteLine(acer.price);
    }
}
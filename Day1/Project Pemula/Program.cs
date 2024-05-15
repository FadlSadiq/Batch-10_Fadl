class Cat
{
    public string colour = "Black";
    
    string species;
    int age;

    public void Eat()
    {
        Console.WriteLine("cat eat");
    }

}

class Program
{
    static void Main()
    {
        Cat caty = new Cat();
        caty.Eat();
        Console.WriteLine(caty.colour);
    }
}
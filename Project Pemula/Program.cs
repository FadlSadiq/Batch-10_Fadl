class Cat
{
    string colour;
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
    }
}
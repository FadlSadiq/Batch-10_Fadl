class Cat
{
    string colour;
    string species;
    int age;

    public void Eat()
    {
        Console.Writeline("cat eat");
    }

}

class Program
{
    static void main()
    {
        Cat caty = new Cat();
        caty.Eat();
    }
}
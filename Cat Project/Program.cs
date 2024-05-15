using System.Data.Common;

class Program
{
    static void Main()
    {
        Car Mustang = new Car("Red", "Mustang", "1969");
        caty.Eat();
    }
}

class Car
{
    public string Brand;
    public string year;
    public string

    public Cat(string favoriteFood, string catName)
    {
        this.favoriteFood = favoriteFood;
        this.catName = catName;
    }

    public void Eat()
    {
        Console.WriteLine(catName + " eats " + favoriteFood);
    }
}
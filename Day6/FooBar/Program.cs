namespace FooBar;
using System.Collections;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        int Numbers;
        Console.WriteLine("How much n do you want to insert?");
        Numbers = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You have inserted {Numbers}");
        FB FooBar = new FB();

        List<string> item = FooBar.Transform(Numbers);
        foreach(var newitem in item)
        {
            Console.WriteLine(newitem);
        }
    }
}

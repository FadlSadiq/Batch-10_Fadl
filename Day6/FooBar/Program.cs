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
        FB newN = new FB();
        newN.ModifyNumbers(Numbers);
        newN.GetNumbers();
        System.Console.WriteLine(newN.GetNumbers());
    //     LinkedList<int> newN = new LinkedList<int>();
    //     newN.AddFirst(n);

        // foreach(int item in newN.GetNumber())
        // {
        //     Console.WriteLine(item);
        // }
    }
}

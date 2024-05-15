namespace FooBar;
using System;

public delegate int MyNumbers(int Numbers);
public class FB
{
    public int Numbers {get; private set;}
    public void ModifyNumbers(int numbers)
    {
        Numbers = numbers;
    }

    // public int Add(params int[] numbers)
    // {
    //     int sum = 0;
    //     foreach(int i in numbers)
    //     {
    //         sum += i;
    //     }
    //     return sum;
    // }
    public IEnumerable<int> GetNumbers(int Numbers)
    {
        for(int i = 0; i <= Numbers; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("Foo");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Bar");
            }
            yield return i;
        }
        
    }
}
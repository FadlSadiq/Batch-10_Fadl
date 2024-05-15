using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
    //list
    List<string> bp = new List<string>{"Lisa", "Jennie", "Jisoo", "Rose"};
    IEnumerator<string> enumerator = bp.GetEnumerator();
    while(enumerator.MoveNext())
    {
        Console.WriteLine(enumerator.Current);
    }
    }

    // iterator
    public static IEnumerable<int> GetNumbers()
    {
        for(int i = 1; i < 100; i++)
        {
            yield return i;
        }
    }

    // List

}
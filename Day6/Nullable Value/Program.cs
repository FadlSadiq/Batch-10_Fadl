using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //Nullable Value
    static void Main()
    {
    int? a = null;
    Nullable<int> nullableInt = null;
    if (a.HasValue)
    {
        System.Console.WriteLine($"a is:{a}");
    }
    else
    {
        System.Console.WriteLine("a doesn't have a value");
    }

//     SampleCompare sp = new SampleCompare();
}

// public interface IComparable<T>
// {
//     public int CompareTo(T other);
// }

// public class SampleCompare : IComparable<string>
// {
//     public int CompareTo(string other)
//     {
//         int x = int.Parse(other);
//         return x;
//     }
}

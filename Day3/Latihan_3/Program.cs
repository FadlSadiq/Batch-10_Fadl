public static class Calculator
{
    public static double Pi= 3.14;
    public static double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Calculator.Add(13.7, 23.5));
        Console.WriteLine(Calculator.Pi);
    
    }
}

// public static class MethodExe
// {
//     public static string ToUpper(this string input);
//     {
//         if(string.IsNullOrEmpty(input))
//         {
//             return input;
//         }
//         return input.ToUpper();
//     }
// }

// public class Program
// {
//     static void Main()
//     {
//         string msg = "Good Morning";
//         Console.WriteLine(MethodeExe.ToUpper(msg));
    
//     }
// }
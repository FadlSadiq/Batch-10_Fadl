using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        StringBuilder text = new();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < 10000000; i++)
        {
            text.Append('a');
            text.Append('b');
            text.Append('c');
        }
        stopwatch.Stop();
        System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
    }
}
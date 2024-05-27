using System;
using System.Threading;

class Program
{
    static object TieMe = new object();
    static void Main()
    {
        Thread one = new Thread(Printer);
        Thread two = new Thread(Printer);
        one.Start();
        two.Start();

        // Console.ReadLine();
    }

    public static void Printer()
    {
        lock (TieMe)
        {
            string prog = "Hi programmer";
            for (int i = 0; i < prog.Length; i++)
            {
                Console.Write($"{prog[i]}");
                Thread.Sleep(TimeSpan.FromSeconds(0.2));
            }
            Console.WriteLine(" ");
        }
    }
}
namespace Latihan_4;

class Program
{
    static void Main()
    {
    string name = "Snoopy";
    int level = 3;
    string job;

    Character.Status(in name, ref level, out job);
    Console.WriteLine(name);
    Console.WriteLine(level);
    Console.WriteLine(job);
    
    }
}
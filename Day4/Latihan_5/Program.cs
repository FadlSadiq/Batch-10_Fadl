namespace Latihan_5;

public enum Job
{
    Warrior, Assassin, Magician = 5, BlackSmith , Clown
}

class Program
{
    static void Main()
    {
        int job = (int)Job.Assassin;
        Console.WriteLine(job);
    }
}
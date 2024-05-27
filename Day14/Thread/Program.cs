class program
{
    static void Main()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

    }
}

class Attack
{
    int MyNumber;

    public void Attacked(){
    for (int i = 0; i < MyNumber; i++)
    {
        System.Console.WriteLine("Attacked");
    }
    }
}

class Heal
{
    int MyNumber;
    public void Attacked()
    {
        for (int i = 0; i < MyNumber; i++)
        {}
    }
}
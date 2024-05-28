class Program
{
    static void Main()
    {
        Thread attack = new(() => Attacked(50));
        Thread attack2 = new(() => Attacked2(40));
        Thread attack3 = new(() => Attacked3(30));
        Thread attack4 = new(() => Attacked4(20));
        Thread attack5 = new(() => Attacked5(10));

        attack.IsBackground = true;
        attack.Name = "goblin";
        attack2.Name = "Troll";
        attack.Priority = ThreadPriority.Normal;

        attack.Start();
        attack2.Start();
        attack3.Start();
        attack4.Start();
        attack5.Start();
    }

    static void Attacked(int Damage)
    {
        System.Console.WriteLine(100 - Damage + " " + Thread.CurrentThread.Name);
    }
    static void Attacked2(int Damage)
    {
        System.Console.WriteLine(93 - Damage + " " + Thread.CurrentThread.Name);
    }
    static void Attacked3(int Damage)
    {
        System.Console.WriteLine(87 - Damage + " " + Thread.CurrentThread.ManagedThreadId);
    }
    static void Attacked4(int Damage)
    {
        System.Console.WriteLine(35 - Damage);
        Thread.Sleep(500);
    }
    static void Attacked5(int Damage)
    {
        System.Console.WriteLine(23 - Damage);
    }

}
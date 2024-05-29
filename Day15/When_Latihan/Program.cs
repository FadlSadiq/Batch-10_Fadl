using System.Security.Cryptography.X509Certificates;

class Program
{
    static async Task Main()
    {
        await Call1();

        static async Task Call1()
        {
        Task task1 = First.Counting();
        Task task2= Second.Counting1();

        Task completedTask = await Task.WhenAny(task1, task2);
        System.Console.WriteLine($"First completed task: " + (completedTask == task1 ? "Task 1" : "Task 2"));
        }

        var task3 = new Task<Dictionary<string, List<int>>>(Third.ReturnData);
        task3.Start();
        foreach(var data in task3.Result)
        {
            System.Console.WriteLine($"Penduduk : {data.Key} : {data.Value}");
        }
    }
}

class First
{
    public static async Task Counting()
    {
        string name = "Robotics";
        for (int i = 0; i < name.Length; i++)
        {
            System.Console.WriteLine("Task 1");
            // Console.Write($"{name[i]}");
            await Task.Delay(TimeSpan.FromSeconds(0.2));
        }
    }
}

class Second
{
    public static async Task Counting1()
    {
        string name = "Dominos";
        for (int i = 0; i < name.Length; i++)
        {
            System.Console.WriteLine("Task 2");
            // Console.Write($"{name[i]}");
            await Task.Delay(TimeSpan.FromSeconds(0.2));
        }
    }
}

class Third
{
    public static int Number()
    {
        return 12;
    }

    public static Dictionary<string, List<int>> ReturnData()
    {
        List<int> list = new();
        Dictionary<string, List<int>> dict = new();
        list.Add(9);
        list.Add(7);
        list.Add(5);
        dict.Add("Brad", list);
        return dict;
    }
}

class Exception
{
    static void ExceptionMaker()
    {
        throw new FormatException("Exception thrown from ExceptionMaker");
    }
    static void CreateException()
    {
        throw new NullReferenceException("Exception thrown from CreateException");
    }
}
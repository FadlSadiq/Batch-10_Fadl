using System.Threading;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Task task = new(() => System.Console.WriteLine("Task 1"));
        task.Start();
        Task task2 = Task.Run(() => System.Console.WriteLine("Task 2"));
        System.Console.WriteLine(task2.IsCompleted);
        // task.Wait();
    }
}
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main()
    {
        InstanceCreator();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        System.Console.WriteLine("Wait for the next order");

    }

    static void InstanceCreator()
    {
        Child child = new();
    }
}

public class GrandParent
{
    ~GrandParent()
    {
        System.Console.WriteLine("GrandParent Eliminated");
    }
}

public class Parent : GrandParent
{
    ~Parent()
    {
        System.Console.WriteLine("Parent Eliminated");
    }
}

public class Child : Parent
{
    ~Child()
    {
    System.Console.WriteLine("Child Eliminated");
    }
}
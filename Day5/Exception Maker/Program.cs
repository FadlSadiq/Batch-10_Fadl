class Program
{
    static void Main()
    {
        try
        {
            ExceptionMaker();
            ExceptionMaker2();
        }
        catch(IndexOutOfRangeException e)
        {

        }
        catch(DivideByZeroException e1)
        {
            System.Console.WriteLine(e1.Message); // xx.Message, Message fitur bagian exception
            System.Console.WriteLine("cannot divided by zero");
        }
        catch(NullReferenceException e2)
        {
            System.Console.WriteLine(e2);
        }
        catch(StackOverflowException e3)
        {

        }
        catch(FormatException e4)
        {
            System.Console.WriteLine(e4.Message);
        }
    }
    static void ExceptionMaker()
    {
        int x = 10, y = 0;
        int result = x/y;
        System.Console.WriteLine(result);
    }
    static void ExceptionMaker2()
    {
        string name = "Snoopy123";
        int names = int.Parse(name);
        System.Console.WriteLine(names);
    }
}


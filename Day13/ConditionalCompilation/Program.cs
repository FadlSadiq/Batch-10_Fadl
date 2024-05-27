class Program
{
    static void Main()
    {
        System.Console.WriteLine("DEBUG");
        #if DEBUG
        System.Console.WriteLine("DEBUG");
        #endif
        #if RELEASE
        System.Console.WriteLine("RELEASE");
        System.Console.WriteLine("BYE BYE");
        System.Console.WriteLine("BBBBBBB");
        #endif
        #if DEVELOPMENT
        System.Console.WriteLine("DEVELOPMENT");
        #endif
    }
}
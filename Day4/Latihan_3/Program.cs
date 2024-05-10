class GenericClass<T> where T : struct
{
    public T Message;
    public void GenericMethod(T Param1, T Param2)
    {
        Console.WriteLine($"Message: {Message}");
    }
}
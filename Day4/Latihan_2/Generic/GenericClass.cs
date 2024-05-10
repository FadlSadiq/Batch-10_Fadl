namespace Generic;
class GenericClass<T1,T2>
{
    public T1 message;
    public void GenericMethod(T1 name, T2 age, T1 location, T1 Hobby)
    {
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Location: {location}");
        Console.WriteLine($"Hobby: {Hobby}");
    }
}

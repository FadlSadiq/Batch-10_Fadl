using Generic;
class Program
{
    static void Main()
    {
    GenericClass<string, int> myGeneric = new GenericClass<string, int>
    {
        message= "Welcome to bootcamp"
    };
    myGeneric.GenericMethod("Fadl", 23, "Salatiga", "Chess");
    }
}
//Interface Segregation Principle
interface IWorkable
{
    void Work();
}
interface IEatable
{
    void Eat();
}

class Worker : IWorkable, IEatable
{
    public void Work()
    {

    }
    public void Eat()
    {

    }
}

class Robot : IWorkable
{
    public void Work()
    {

    }
    // public void Eat()
    // {
    //     throw new NotFiniteNumberException();
    // }
}
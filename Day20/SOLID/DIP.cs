//Depedency Inversion Principle
public interface IDevice
{
    public void TurnOn();
}

public class LightBulb : IDevice
{
    public void TurnOn()
    {
        // Turn on the bulb
    }
}

public class PC : IDevice
{
    public void TurnOn()
    {

    }
}

public class Switch
{
    private IDevice _device;
    public Switch(IDevice device)
    {
        _device = device;
    }
    public void Operate()
    {
        _device.TurnOn();
    } 
}

// class Program
// {
//     static void Main()
//     {
//         Switch switch = new();

//     }
// }
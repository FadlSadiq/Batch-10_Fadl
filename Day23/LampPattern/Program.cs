public interface ILamp
{
    public void TurnOn();
    public void TurnOff()
}

public class VendoraBAdapter : ILamp
{
    public VendoraBLight vendoraBLight;
    public bool turn;

    public void TurnOn
}

public class VendorALight : ILamp
{
public void TurnOn();
public void TurnOff();
}

public class VendorBLight
{
    Public void TurnLight(bool on);
}
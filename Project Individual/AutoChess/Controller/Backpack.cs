using Interface;
public class Backpack
{
    public int BackpackId{get; private set;}
    public readonly int backpackMaxCapacity;
    public Backpack(int backpackId, int backpackMaxCapacity = 20)
    {
        BackpackId = backpackId;
        this.backpackMaxCapacity = backpackMaxCapacity;
    }
}
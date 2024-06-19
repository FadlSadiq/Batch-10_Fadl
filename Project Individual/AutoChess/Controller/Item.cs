using Interface;

public class Item : IItem
{
    public Guid ItemId {get; private set;}
    public string ItemName {get; private set;}

    public Item(string itemName)
    {
        ItemId = new Guid();
        ItemName = itemName;
    }
}
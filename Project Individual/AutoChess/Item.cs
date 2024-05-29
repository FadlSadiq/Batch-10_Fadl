class Item
{
    public int ItemId {get; private set;}
    public string ItemName {get; private set;}

    public Item(int itemId, string itemName)
    {
        ItemId = itemId;
        ItemName = itemName;
    }
}
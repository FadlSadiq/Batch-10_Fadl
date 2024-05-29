class ItemData
{
    public string ItemDesc {get; private set;}
    public bool IsEquipped {get; private set;}

    public ItemData(string itemDesc, bool isEquipped)
    {
        ItemDesc = itemDesc;
        IsEquipped = isEquipped;
    }
    public bool UpdateEquipStatus(GameState gameState, bool isEquipped)
    {
        return;
    }
}
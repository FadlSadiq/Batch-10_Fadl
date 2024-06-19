public class ItemData
{
    public string ItemAttributes {get; private set;}
    public string ItemEffect {get; private set;}
    public bool IsEquipped {get; private set;}

    public ItemData(string itemAttributes, string itemEffect, bool isEquipped)
    {
        ItemAttributes = itemAttributes;
        ItemEffect = itemEffect;
        IsEquipped = isEquipped;
    }
    public bool UpdateEquipStatus(GameState gameState, bool isEquipped)
    {
        if (gameState == GameState.Preparation)
        {
            IsEquipped = isEquipped;
            return true; 
        }
        return false;
    }
}
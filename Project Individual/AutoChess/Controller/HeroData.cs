using System.IO.Compression;

// Reference HeroData AutoChess : https://ac.dragonest.com/en/charactor
public class HeroData
{
    public int HeroLevel{get; private set;}
    public int HeroHp{get; private set;}
    public double Atk{get; private set;}
    public int Armor{get; private set;}
    public double AtkSpeed{get; private set;}
    public int MagicResistance{get; private set;}
    public int Range{get; private set;}
    public int DamageToPlayer{get; private set;}
    public int HeroPrice{get; private set;}
    public HeroClass HeroClass{get; private set;}
    public HeroRace HeroRace{get; private set;}
    public HeroRarity HeroRarity{get; private set;}
    public HeroState HeroState{get; private set;}
    // public Item ItemEquipped{get; private set;}
    public bool CanLevelUp{get; private set;}
    public bool IsBot{get; private set;}
    public bool IsEquipItem{get; private set;}
    public bool IsDroppingItem{get; private set;}
    public int AvailableToPurchase{get; private set;}
    public HeroData(int heroLevel, int heroHp, int armor, int magicResistance, int heroPrice, int damageToPlayer, double atk, double atkSpeed, int availableToPurchase, HeroClass heroClass, HeroRace heroRace, HeroRarity heroRarity, HeroState heroState)
    {
        HeroLevel = heroLevel;
        HeroHp = heroHp;
        Armor = armor;
        MagicResistance = magicResistance;
        DamageToPlayer = damageToPlayer;
        HeroPrice = heroPrice;
        Atk = atk;
        AtkSpeed = atkSpeed;
        AvailableToPurchase = availableToPurchase;
        HeroClass = heroClass;
        HeroRace = HeroRace;
        HeroRarity = heroRarity;
        HeroState = heroState;
    }
    public bool EquiptItem(GameState gameState, bool isEquipItem)
    {
        if (gameState == GameState.Preparation)
        {
            IsEquipItem = isEquipItem;
            return true; 
        }
        return false;
    }
    public void LevelUp(bool CanLevelUp)
    {
        if (CanLevelUp == true)
        {
            HeroLevel++;
        }
    }
    public void UpdateAvailableToPurchase()
    {
        if (AvailableToPurchase > 0)
        {
            AvailableToPurchase--;
        }
    }
    public void UpdateDroppingItem(bool isBot)
    {
        if (isBot == true)
        {
            IsDroppingItem = true;
        }
    }
    public void SetPrice(int priceHero)
    {
        HeroPrice = priceHero;
    }
}
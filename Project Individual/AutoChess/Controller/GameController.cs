namespace Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Interface;

public class GameController
{
    private List<IPlayer> _players;
    private List<IHero> hero;
    private Dictionary<IPlayer, PlayerData> playerData;
    private Dictionary<IHero, HeroData> heroData;
    private Dictionary<IPlayer, IBackpack> backpackData;
    private Dictionary<IPlayer, List<IHero>> herosPlayer;
    private Dictionary<IPlayer, Arena> playerArena;
    private Dictionary<IPlayer, Bench> playerBench;
    private Dictionary<ICommunityPool, List<IHero>> heroOnStore;
    private Dictionary<Board, List<IHero>> herosOnBoard;
    private Dictionary<Arena, List<IHero>> herosOnArena;
    private Dictionary<Bench, List<IHero>> herosOnBench;
    private Dictionary<IItem, ItemData> itemData;
    private Dictionary<IHero, IItem> itemEquipped;
    private Dictionary<IHero, Board> herosPosition;
    private Dictionary<IBackpack, List<IItem>> itemStored;
    private Dictionary<IPlayer, int> maxHeroOnBoard;
    private Dictionary<List<IHero>, int> specialStatHp;
    //private Dictionary<CommunityPool, Dictionary<IHero, HeroData>>
    public Board BoardData { get; private set; }
    public Arena ArenaData { get; private set; }
    public Bench BenchData { get; private set; }
    public ICommunityPool CommunityPoolData { get; private set; }
    public int CurrentBoard { get; private set; }
    public int ActivePlayer { get; private set; }
    public readonly int maxPlayerNumber;
    public readonly int maxRound;
    public GameState GameState { get; private set; }
    public Action<GameState> OnOpenCommunityPool;
    public Action<IPlayer, ICommunityPool> OnCloseCommunityPool;
    public Action<IHero, HeroData> OnPurchaseHero;
    public Action<IPlayer, ICommunityPool> OnRerollHero;
    public Action<IPlayer, ICommunityPool> OnSellHero;
    public Action<IBackpack, IItem> OnFetchItem;
    public Action<IHero, IItem> OnEquipItem;
    public Action<IPlayer, IHero> OnLevelUpHero;
    public Func<IHero, IItem, bool> OnCheckEquipItem;
    public Func<int, bool> ResultRound;
    public Predicate<Board> OnMoveHero;
    public GameController()
    {
        
    }
    public GameController(Arena arena, Bench bench, GameState gameState, int maxPlayerNumber = 8, int maxRound = 50)
    {
        _players = new();
        ArenaData = arena;
        BenchData = bench;
        GameState = gameState;
        // ResultRound = PlayerData.SetRoundResult;
        // Default Delegate
        // OnOpenCommunityPool = CommunityPoolData.OpenCommunityPool;

    }
    public void AddPlayer(Player player)
    {
        // System.Console.WriteLine("How Many Player are Playing? max 8");
        // int numberPlayer = Convert.ToInt32(Console.ReadLine());
        List<Player> players = new();
        DataContractJsonSerializer serializer = new(typeof(List<IPlayer>));
        using (FileStream CreatePlayer = new("Players.json", FileMode.Create))
        {
            for (int i = 1; i < ActivePlayer + 1; i++)
            {
                Console.Clear();
                System.Console.WriteLine($"Player {i} Name :");
                string PlayerName = Console.ReadLine();
                int PlayerId = Convert.ToInt32(Guid.NewGuid());
                Player newplayers = new(PlayerId, PlayerName);
                if (i == ActivePlayer - 1)
                {
                    SetGameState(GameState.Preparation);
                    serializer.WriteObject(CreatePlayer, newplayers);
                }
            }
        }
    }
    public void SetActivePlayer(int ActivePlayer)
    {
        this.ActivePlayer = ActivePlayer;
    }
    public PlayerData GetPlayerData(IPlayer player)
    {
        return playerData[player];
    }
    public HeroData GetHeroData(IHero hero)
    {
        return heroData[hero];
    }
    public IBackpack GetBackPackData(IPlayer player)
    {
        return backpackData[player];
    }
    public Arena GetPlayerArena(IPlayer player)
    {
        return playerArena[player];
    }
    public Bench GetPlayerBench(IPlayer player)
    {
        return playerBench[player];
    }
    public List<IHero> GetHerosPlayer(IPlayer player)
    {
        return herosPlayer[player];
    }
    public List<IHero> GetHeroOnStore(ICommunityPool communityPool)
    {
        return heroOnStore[communityPool];
    }
    public List<IHero> GetHeroOnBoard(Board board)
    {
        return herosOnBoard[board];
    }
    public List<IHero> GetHeroOnArena(Arena arena)
    {
        return herosOnArena[arena];
    }
    public List<IHero> GetHeroOnBench(Bench bench)
    {
        return herosOnBench[bench];
    }
    public ItemData GetItemData(IItem item)
    {
        return itemData[item];
    }
    public IItem GetItemEquipped(IHero hero)
    {
        return itemEquipped[hero];
    }
    public Board GetHerosPosition(IHero hero)
    {
        return herosPosition[hero];
    }
    public List<IItem> GetItemStored(IBackpack backpack)
    {
        return itemStored[backpack];
    }
    public int GetMaxHeroOnBoard(IPlayer player)
    {
        return playerData[player].Level;
    }
    public int GetSpecialStatHP(List<IHero> heroOnBoard)
    {
        return specialStatHp[heroOnBoard];
    }
    public Dictionary<IPlayer, PlayerData> GetAllPlayerData()
    {
        return playerData;
    }
    public Dictionary<IHero, HeroData> GetAllHeroData()
    {
        return heroData;
    }
    public Dictionary<IPlayer, Arena> GetAllArenaData()
    {
        return playerArena;
    }
    public Dictionary<IPlayer, Bench> GetAllBenchData()
    {
        return playerBench;
    }
    public Dictionary<IPlayer, IBackpack> GetAllBackpackData()
    {
        return backpackData;
    }
    public Dictionary<IPlayer, List<IHero>> GetAllHerosPlayer()
    {
        return herosPlayer;
    }
    public Dictionary<ICommunityPool, List<IHero>> GetAllHeroOnStore()
    {
        return heroOnStore;
    }
    public Dictionary<Board, List<IHero>> GetAllHeroOnBoard()
    {
        return herosOnBoard;
    }
    public Dictionary<Arena, List<IHero>> GetAllHeroOnArena()
    {
        return herosOnArena;
    }
    public Dictionary<Bench, List<IHero>> GetAllHeroOnBench()
    {
        return herosOnBench;
    }
    public Dictionary<IItem, ItemData> GetAllItemData()
    {
        return itemData;
    }
    public Dictionary<IHero, IItem> GetAllItemEquipped()
    {
        return itemEquipped;
    }
    public Dictionary<IHero, Board> GetAllHerosPosition()
    {
        return herosPosition;
    }
    public Dictionary<IBackpack, List<IItem>> GetAllItemStored()
    {
        return itemStored;
    }
    public bool SetGameState(GameState gamestate)
    {
        GameState = gamestate;
        return true;
    }
    public bool RemoveDefeatedPlayer(int player)
    {
        foreach (var playerid in _players)
        {
            if (playerid.PlayerId == player)
            {
                _players.Remove(playerid);
                return true;
            }
        }
        return false;
    }
    public List<IHero> ReRollHero(ICommunityPool communityPool)
    {
        return heroOnStore[communityPool];
    }

    public void SetPlayetData(Dictionary<IPlayer, PlayerData> playerData)
    {
        this.playerData = playerData;
    }
    public void SetHeroData(Dictionary<IHero, HeroData> heroData)
    {
        this.heroData = heroData;
    }
    public void SetBackpackData(Dictionary<IPlayer, IBackpack> backpackData)
    {
        this.backpackData = backpackData;
    }
    public void SetPlayerArena(Dictionary<IPlayer, Arena> playerArena)
    {
        this.playerArena = playerArena;
    }
    public void SetPlayerBench(Dictionary<IPlayer, Bench> playerBench)
    {
        this.playerBench = playerBench;
    }
    public void SetHerosPlayer(Dictionary<IPlayer, List<IHero>> herosPlayer)
    {
        this.herosPlayer = herosPlayer;
    }
    public void SetHeroOnStore(Dictionary<ICommunityPool, List<IHero>> heroOnStore)
    {
        this.heroOnStore = heroOnStore;
    }
    public void SetHeroOnBoard(Dictionary<Board, List<IHero>> herosOnBoard)
    {
        this.herosOnBoard = herosOnBoard;
    }
    public void SetHeroOnArena(Dictionary<Arena, List<IHero>> herosOnArena)
    {
        this.herosOnArena = herosOnArena;
    }
    public void SetHeroOnBench(Dictionary<Bench, List<IHero>> herosOnBench)
    {
        this.herosOnBench = herosOnBench;
    }
    public void SetItemData(Dictionary<IItem, ItemData> itemData)
    {
        this.itemData = itemData;
    }
    public void SetItemEquipped(Dictionary<IHero, IItem> itemEquipped)
    {
        this.itemEquipped = itemEquipped;
    }
    public void SetHerosPosition(Dictionary<IHero, Board> herosPosition)
    {
        this.herosPosition = herosPosition;
    }
    public void SetItemStored(Dictionary<IBackpack, List<IItem>> itemStored)
    {
        this.itemStored = itemStored;
    }
    public void SetMaxHeroOnBoard(Dictionary<IPlayer, int> maxHeroOnBoard)
    {
        this.maxHeroOnBoard = maxHeroOnBoard;
    }
    public void SetSpecialStatHP(Dictionary<List<IHero>, int> specialStatHp)
    {
        this.specialStatHp = specialStatHp;
    }
    public int CheckPlayerNumber()
    {
        int CountPlayer = _players.Count;
        return CountPlayer;
    }
    public Dictionary<string, List<HeroData>> GenerateHeroesOnStore(GameState gameState)
    {
        Dictionary<string, List<HeroData>> heroDictionary = new Dictionary<string, List<HeroData>>();

        if (gameState == GameState.Preparation)
        {
            string result;
            using (StreamReader sr = new StreamReader("../AutoChess/Data/HeroBackUp.Json"))
            {
                result = sr.ReadToEnd();
                Dictionary<string, List<HeroData>> heroes = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, List<HeroData>>>(result);
                Random rnd = new Random();
                HashSet<int> chosenIndices = new HashSet<int>(); // To keep track of chosen indices
                int heroesCount = heroes.Count;

                // Ensure we select 5 unique heroes or less if there are fewer heroes available
                for (int i = 0; i < Math.Min(5, heroesCount); i++)
                {
                    int heroIndex;
                    do
                    {
                        heroIndex = rnd.Next(0, heroesCount);
                    } while (chosenIndices.Contains(heroIndex)); // Ensure uniqueness

                    chosenIndices.Add(heroIndex);
                    KeyValuePair<string, List<HeroData>> heroPair = heroes.ElementAt(heroIndex);
                    string heroName = heroPair.Key;
                    HeroData heroData = heroPair.Value[0];
                    heroDictionary.Add(heroName, heroPair.Value);
                }
            }
        }
        return heroDictionary;
    }
    public void StartRound(GameState gamestate)
    {
        if (gamestate == GameState.Ongoing)
        {
            AutoAttack();
        }
    }
    public void AutoAttack()
    {
        
    }
    public void SetMaxHeroOnBoard(IPlayer player)
    {

    }
    public void AddSpecialHeroStateHP(IPlayer player, List<IHero> hero, Board board)
    {

    }
    public void AddBot(List<IHero> heroOnBoard, Board board, int currentRound)
    {
        if (currentRound % 5 == 0)
        {

        }
    }
    public void RandomItemDrop(IHero bot, IItem item)
    {

    }
}
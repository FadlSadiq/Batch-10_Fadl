// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Runtime.Serialization;
// using System.Runtime.Serialization.Json;
// using Interface;

// public class GameController
// {
//     private List<IPlayer> _players;
//     private List<IHero> hero;
//     private Dictionary<IPlayer, PlayerData> playerData;
//     private Dictionary<IHero, HeroData> heroData;
//     private Dictionary<IPlayer, IBackpack> backpackData;
//     private Dictionary<IPlayer, List<IHero>> herosPlayer;
//     private Dictionary<ICommunityPool, List<IHero>> heroOnStore;
//     private Dictionary<Board, List<IHero>> heroOnBoard;
//     private Dictionary<Arena, List<IHero>> heroOnArena;
//     private Dictionary<Bench, List<IHero>> heroOnBench;
//     private Dictionary<IItem, ItemData> itemData;
//     private Dictionary<IHero, Item> itemEquipped;
//     private Dictionary<IHero, Board> herosPosition;
//     private Dictionary<IBackpack, List<IItem>> itemStored;
//     private Dictionary<IPlayer, int> maxHeroOnBoard;
//     private Dictionary<List<IHero>, int> specialStatHp;
//     public Board BoardData { get; private set; }
//     public Arena ArenaData { get; private set; }
//     public Bench BenchData { get; private set; }
//     public ICommunityPool CommunityPoolData { get; private set; }
//     public int CurrentBoard { get; private set; }
//     private int _activePlayer;
//     public readonly int MaxPlayerNumber;
//     public readonly int MaxRound;
//     public GameState GameState { get; private set; }
//     public Action<IPlayer, ICommunityPool> OnOpenCommunityPool;
//     public Action<IPlayer, ICommunityPool> OnCloseCommunityPool;
//     public Action<IPlayer, ICommunityPool> OnPurchaseHero;
//     public Action<IPlayer, ICommunityPool> OnRerollHero;
//     public Action<IPlayer, ICommunityPool> OnSellHero;
//     public Action<IBackpack, IItem> OnFetchItem;
//     public Action<IHero, IItem> OnEquipItem;
//     public Action<IPlayer, IHero> OnLevelUpHero;
//     public Func<IHero, IItem, bool> OnCheckEquipItem;
//     public Func<int, bool> ResultRound;
//     public Predicate<Board> OnMoveHero;
//     public GameController(int maxPlayerNumber = 8, int maxRound = 50, Board board, GameState gameState)
//     {
//         MaxPlayerNumber = maxPlayerNumber;
//         MaxRound = maxRound;
//         _players = new();
//         BoardData = board;
//         GameState = gameState;
//         ResultRound = PlayerData.SetRoundResult;
//     }
//     public void AddPlayer(Player player)
//     {
//         System.Console.WriteLine("How Many Player are Playing?");
//         int numberPlayer = Convert.ToInt32(Console.ReadLine());
//         List<Player> players = new();
//         DataContractJsonSerializer serializer = new(typeof(List<IPlayer>));
//         using (FileStream CreatePlayer = new("Players.json", FileMode.Create))
//         {
//             for (int i = 1; 1 < numberPlayer + 1; i++)
//             {
//                 Console.Clear();
//                 System.Console.WriteLine($"Player {i} Name :");
//                 string PlayerName = Console.ReadLine();
//                 int PlayerId = Convert.ToInt32(Guid.NewGuid());
//                 Player newplayers = new(PlayerId, PlayerName);
//             }
//             serializer.WriteObject(CreatePlayer, players);
//         }
        

//     }
//     public PlayerData GetPlayerData(IPlayer player)
//     {
//         return playerData[player];
//     }
//     public HeroData GetHeroData(IHero hero)
//     {
//         return heroData[hero];

//     }
//     public IBackpack GetBackPackData(IPlayer player)
//     {
//         return backpackData[player];
//     }
//     public List<IHero> GetHerosPlayer(IPlayer player)
//     {
//         return herosPlayer[player];
//     }
//     public List<IHero> GetHeroOnStore(ICommunityPool communityPool)
//     {
//         return heroOnStore[communityPool];
//     }
//     public List<IHero> GetHeroOnBoard(Board board)
//     {
//         return heroOnBoard[board];
//     }
//     public List<IHero> GetHeroOnArena(Arena arena)
//     {
//         return heroOnArena[arena];
//     }
//     public List<IHero> GetHeroOnBench(Bench bench)
//     {
//         return heroOnBench[bench];
//     }
//     public ItemData GetItemData(IItem item)
//     {
//         return itemData[item];
//     }
//     public Item GetItemEquipped(IHero hero)
//     {
//         return itemEquipped[hero];
//     }
//     public Board GetHerosPosition(IHero hero)
//     {
//         return herosPosition[hero];
//     }
//     public List<IItem> GetItemStored(IBackpack backpack)
//     {
//         return itemStored[backpack];
//     }
//     public int GetMaxHeroOnBoard(IPlayer player)
//     {
//         return playerData[player].Level;
//     }
//     public int GetSpecialStatHP(List<IHero> heroOnBoard)
//     {
//         return specialStatHp[heroOnBoard];
//     }
//     public Dictionary<IPlayer, PlayerData> GetAllPlayerData()
//     {
//         return playerData;
//     }
//     public Dictionary<IHero, HeroData> GetAllHeroData()
//     {
//         return heroData;
//     }
//     public Dictionary<IPlayer, IBackpack> GetAllBackpackData()
//     {
//         return backpackData;
//     }
//     public Dictionary<IPlayer, List<IHero>> GetAllHerosPlayer()
//     {
//         return herosPlayer;
//     }
//     public Dictionary<ICommunityPool, List<IHero>> GetAllHeroOnStore()
//     {
//         return heroOnStore;
//     }
//     public Dictionary<Board, List<IHero>> GetAllHeroOnBoard()
//     {
//         return heroOnBoard;
//     }
//     public Dictionary<Arena, List<IHero>> GetAllHeroOnArena()
//     {
//         return heroOnArena;
//     }
//     public Dictionary<Bench, List<IHero>> GetAllHeroOnBench()
//     {
//         return heroOnBench;
//     }
//     public Dictionary<IItem, ItemData> GetAllItemData()
//     {
//         return itemData;
//     }
//     public Dictionary<IHero, Item> GetAllItemEquipped()
//     {
//         return itemEquipped;
//     }
//     public Dictionary<IHero, Board> GetAllHerosPosition()
//     {
//         return herosPosition;
//     }
//     public Dictionary<IBackpack, List<IItem>> GetAllItemStored()
//     {
//         return itemStored;
//     }
//     public bool SetGameState(GameState gamestate)
//     {
//         GameState = gamestate;
//         return true;
//     }
//     public bool RemoveDefeatedPlayer(int player)
//     {
//         foreach (var playerid in _players)
//         {
//             if (playerid.PlayerId == player)
//             {
//                 _players.Remove(playerid);
//                 return true;
//             }
//         }
//         return false;
//     }
//     public List<IHero> ReRollHero(ICommunityPool communityPool)
//     {
//         return heroOnStore[communityPool];
//     }

//     public int CheckPlayerNumber()
//     {
//         int CountPlayer = _players.Count;
//         return CountPlayer;
//     }
//     public void GenerateHeroesOnStore(ICommunityPool communityPool)
//     {
//         // Your implementation here
//     }
//     public void StartRound(GameState gamestate)
//     {
//         if (gamestate == GameState.Ongoing)
//         {

//         }
//     }
//     public void SetMaxHeroOnBoard(IPlayer player)
//     {

//     }
//     public void AddSpecialHeroStateHP(IPlayer player, List<IHero> hero, Board board)
//     {

//     }
//     public void AddBot(List<IHero> heroOnBoard, Board board, int currentRound)
//     {
//         if (currentRound % 5 == 0)
//         {

//         }
//     }
//     public void RandomItemDrop(IHero bot, IItem item)
//     {

//     }
// }
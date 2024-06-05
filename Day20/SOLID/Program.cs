public class GameController
{
    private List<IPlayer> _playerList = new();
    private void SetAllPlayer(List<IPlayer> player)
    {
        _playerList.AddRange(player);
    }
    Dictionary<IPlayer, List<ICard>> playerCard = new();
    public void SetPlayer(IPlayer player)
    {
        _playerList.Add(player);
    }
    public List<ICard> GetPossibleCard(IPlayer p)
    {
        return playerCard[p];
    }
    public void SetPlayerCard(IPlayer player, List<ICard> cards)
    {
        playerCard.Add(player, cards);
    }
}

public class Player : IPlayer
{
    public string PlayerName { get; private set; }
    public Player(string playerName)
    {
        PlayerName = playerName;
    }
}
public class Card : ICard
{
    public string CardName { get; private set; }
    public Card(string cardName)
    {
        CardName = cardName;
    }
}
public interface IPlayer
{
    public string PlayerName { get; }
}
public interface ICard
{
    public string CardName { get; }
}

class Program
{
    static void Main()
    {
        GameController _game = new();
        Player _player = new("Jojo");
        _game.SetPlayer(_player);
        _game.SetPlayer(new Player("Toni"));
        Card card = new("Magic");
        Card card1 = new("Spell");
        List<ICard> cards = new()
        {
            card, card1
        };
        _game.SetPlayerCard(_player, cards);
        List<ICard> carding = _game.GetPossibleCard(_player);
        foreach(Card kartu in carding)
        {
            System.Console.WriteLine(kartu.CardName);
        }
    }
}
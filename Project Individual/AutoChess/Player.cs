class Player : IPlayer
{
    public int PlayerId {get; private set;}
    public string PlayerName {get; private set;}

    public Player(int playerId, string playerName)
    {
        PlayerId = playerId;
        PlayerName = playerName;
    }
}
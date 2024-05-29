using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

[DataContract]

class Player
{
    [DataMember]
    private string _name;
    [DataMember]
    private int _money;
    [DataMember]
    public int Gold { get; set; }
    [DataMember]
    public int Exp { get; set; }

    public Player(string name, int money, int gold, int exp)
    {
        _name = name;
        _money = money;
        Gold = gold;
        Exp = exp;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetMoney()
    {
        return _money;
    }
}

class Program
{
    static void Main()
    {
        Player juan = new Player("Juan", 2000, 300, 1500);
        Player juna = new Player("juna", 4000, 400, 4500);
        Player didi = new Player("didi", 5000, 500, 7500);

        List<Player> player = new List<Player>()
        {
            juan, juna, didi
        };

        Dictionary<int, List<Player>> players = new Dictionary<int, List<Player>>()
        {
            {1, player}
        };
        
        Dictionary<int, Player> players2 = new Dictionary<int, Player>()
        {
            {1, juan}, 
            {2, juna}, 
            {3, didi}
        };

        DataContractJsonSerializer serializer = new(typeof(Dictionary<int, List<Player>>));
        DataContractJsonSerializer serializer2 = new(typeof(Dictionary<int, Player>));
        using (FileStream fs = new("players.json", FileMode.Create))
        {
            serializer.WriteObject(fs,players);
            serializer2.WriteObject(fs,players2);
        }
    }


}
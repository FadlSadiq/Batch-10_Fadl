using Controller;

namespace AutoChess.Testing;

public class Tests
{
    private GameController _gamecon;
    [SetUp]
    public void Setup()
    {
        _gamecon = new GameController();
    }

    [Test]
    public void CheckPlayerNumber_ReturnPlayerNumber()
    {
        //Arrange
        Player juan = new Player(1,"Juan");
        Player juna = new Player(2,"juna");
        Player didi = new Player(3, "didi");
        int expected = 2; 
        //Action
        List<Player> _players = new()
        {
            juan, juna, didi
        };
        int aa = _players.Count;
        int result = _gamecon.CheckPlayerNumber(_players);
        //Assert
        Assert.AreEqual(expected, result);
    }   
}
using System.Drawing;

public class Arena : Board
{
    public Guid ArenaID { get; set; }
    public override bool IsPositionAvailable(GameState gameState, List<Position> boardPosition)
    {
        bool result = false;
        if (gameState == GameState.Preparation)
        {
            foreach (Position position in boardPosition)
            {
                if (_boardPosition!.Contains(position))
                {
                    result = true;
                }
            }
            
        }
        return result;
    }
    
    public Arena(List<Position> positionAvailable)
    {
        ArenaID = new Guid();
        _boardPosition = positionAvailable;
    }
    public List<Position> GetBoardPosition()
    {
        return _boardPosition!;
    }
}
using System.Drawing;

public class Arena : Board
{
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
    public Arena()
    {

    }
    public Arena(List<Position> positionAvailable)
    {
        _boardPosition = positionAvailable;
    }
    public List<Position> GetBoardPosition()
    {
        return _boardPosition!;
    }
}
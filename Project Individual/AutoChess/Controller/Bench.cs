public class Bench : Board
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
    public Bench(List<Position> positionAvailable)
    {
        _boardPosition = positionAvailable;
    }
    public List<Position> _GetBenchPosition()
    {
        return _boardPosition!;
    }
}
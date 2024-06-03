public abstract class Board
{
    protected List<Position>? _boardPosition;
    public abstract bool IsPositionAvailable(GameState gameState, List<Position> boardPosition);
}
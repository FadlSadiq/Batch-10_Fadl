public struct Position
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override bool Equals(object obj) => obj is Position position && X == position.X && Y == position.Y;
    public override int GetHashCode() => (X, Y).GetHashCode();
    public static bool operator ==(Position X, Position Y)
    {
        return EqualityComparer<Position>.Default.Equals(X, Y);
    }
    public static bool operator !=(Position X, Position Y) => !(X == Y);

}
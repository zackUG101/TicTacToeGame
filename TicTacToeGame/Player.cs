public abstract class Player : IPlayer
{
    public char Symbol { get; protected set; }

    protected Player(char symbol)
    {
        Symbol = symbol;
    }

    public abstract int Move(char[,] board);
}
public interface IPlayer
{
    char Symbol { get; }
    int Move(char[,] board);
}
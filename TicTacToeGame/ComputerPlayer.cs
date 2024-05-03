public class ComputerPlayer : Player
{
    public ComputerPlayer(char symbol) : base(symbol) { }

    public override int Move(char[,] board)
    {
        Random random = new Random();
        int index;
        do
        {
            index = random.Next(9);
        } while (board[index / 3, index % 3] != ' ');
        return index;
    }
}
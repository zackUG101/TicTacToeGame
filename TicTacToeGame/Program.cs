internal class Program
{
    private static void Main(string[] args)
    {
        IPlayer human = new HumanPlayer('X');
        IPlayer computer = new ComputerPlayer('O');
        Game game = new Game(human, computer);
        game.Start();
    }
}
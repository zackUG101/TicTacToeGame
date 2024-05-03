public class Game
{
    private Board gameBoard = new Board();
    private IPlayer player1;
    private IPlayer player2;

    public static bool IsPlayerOneTurn = false;

    public Game(IPlayer p1, IPlayer p2)
    {
        player1 = p1;
        player2 = p2;
    }

    public void Start()
    {
        IPlayer currentPlayer = player1;
        IsPlayerOneTurn = true;

        while (!gameBoard.IsFull() && !gameBoard.CheckWin())
        {
            gameBoard.Display();
            int move = currentPlayer.Move(gameBoard.board);
            if (gameBoard.PlaceMove(move, currentPlayer.Symbol))
            {
                if (gameBoard.CheckWin())
                {
                    Console.WriteLine($"\nPlayer {currentPlayer.Symbol} wins!");
                    gameBoard.Display();
                    return;
                }
                IsPlayerOneTurn = !IsPlayerOneTurn;
                currentPlayer = IsPlayerOneTurn ? player1 : player2;
            }
            else
            {
                Console.WriteLine("Invalid move, try again.");
            }
        }

        Console.WriteLine("\nGame draw!");
        gameBoard.Display();
    }
}

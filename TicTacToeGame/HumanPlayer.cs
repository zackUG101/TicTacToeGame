public class HumanPlayer : Player
{
    public HumanPlayer(char symbol) : base(symbol) { }

    public override int Move(char[,] board)
    {
        while (true)
        {
            Console.Write("\nEnter your move (1-9): ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= 9)
                return index;
            else
                Console.WriteLine("Invalid input. Please try again.");
        }
    }
}
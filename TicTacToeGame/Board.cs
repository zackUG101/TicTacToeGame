public class Board
{
    public char[,] board = new char[3, 3];

    public Board()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                board[i, j] = ' ';
    }

    public bool IsFull()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (board[i, j] == ' ')
                    return false;
        return true;
    }

    public bool PlaceMove(int move, char symbol)
    {
        int pos = move;
        if (Game.IsPlayerOneTurn)
        {
            pos = move - 1;
        }
        int row = pos / 3;
        int col = pos % 3;
        if (board[row, col] == ' ')
        {
            board[row, col] = symbol;
            return true;
        }
        return false;
    }

    public bool CheckWin()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                return true;
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                return true;
        }
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            return true;
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            return true;

        return false;
    }

    public void Display()
    {
        Console.WriteLine("");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("-----");
        }
    }
}

using System;

static void PlayMatch()
{
    char[,] board = new char[3, 3];
    InitializeBoard(board);

var rnd = new Random();
char currentPlayer = rnd.Next(2) == 0 ? 'X' : 'O';
Console.WriteLine($"Starting player (random): {currentPlayer}");


bool gameOver = false;
int moves = 0;
while (!gameOver && moves < 9)
{
    DisplayBoardWithIndices(board);
    Console.WriteLine($"Player {currentPlayer}'s turn. Enter position (row column) between 1 and 3:");

    int row, col;
    // read until a valid position and empty cell are provided
    while (!ReadPosition(out row, out col) || !IsCellEmpty(board, row - 1, col - 1))
    {
        if (row >= 1 && row <= 3 && col >= 1 && col <= 3)
        {
            if (!IsCellEmpty(board, row - 1, col - 1))
                Console.WriteLine("Cell already occupied. Choose another.");
        }
        else
        {
            Console.WriteLine("Invalid input. Type two numbers between 1 and 3 separated by a space (e.g.: 2 3).");
        }

        Console.Write("Position: ");
    }

    // adjust to 0-based index
    row--; col--;

    board[row, col] = currentPlayer;
    moves++;

    if (CheckWinner(board, currentPlayer))
    {
        DisplayBoardWithIndices(board);
        Console.WriteLine($"Player {currentPlayer} wins!");
        gameOver = true;
        break;
    }

    if (moves >= 9)
    {
        DisplayBoardWithIndicesAndMessage(board, "Draw! There are no empty positions left.");
        break;
    }

    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
}

}

static void InitializeBoard(char[,] board)
{
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 3; j++)
            board[i, j] = ' ';
}

static void DisplayBoardWithIndices(char[,] board)
{
    Console.WriteLine();
    Console.Write("   ");
    for (int col = 1; col <= 3; col++)
        Console.Write($" {col}  ");
    Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    Console.Write($" {i + 1} ");
    for (int j = 0; j < 3; j++)
    {
        Console.Write($" {board[i, j]} ");
        if (j < 2) Console.Write("|");
    }
    Console.WriteLine();
    if (i < 2) Console.WriteLine("   ---+---+---");
}
Console.WriteLine();

}

static void DisplayBoardWithIndicesAndMessage(char[,] board, string message)
{
    DisplayBoardWithIndices(board);
    Console.WriteLine(message);
}

static bool ReadPosition(out int row, out int col)
{
    row = -1; col = -1;
    string input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input)) return false;

var parts = input.Trim().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
if (parts.Length != 2) return false;

if (!int.TryParse(parts[0], out row)) return false;
if (!int.TryParse(parts[1], out col)) return false;

if (row < 1 || row > 3 || col < 1 || col > 3) 
    return false;

return true;

}

static bool IsCellEmpty(char[,] board, int row0, int col0)
{
    return board[row0, col0] == ' ';
}

static bool CheckWinner(char[,] board, char player)
{
    // check rows
    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
            return true;
    }

// check columns
    for (int j = 0; j < 3; j++)
    {
        if (board[0, j] == player && board[1, j] == player && board[2, j] == player)
            return true;
    }

// diagonals
    if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
        return true;

    if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
        return true;

    return false;
}

static bool AskToRestart()
{
    Console.Write("Play again? (y/n): ");
    while (true)
    {
        string answer = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(answer)) continue;
        answer = answer.Trim().ToLowerInvariant();
        if (answer == "y" || answer == "yes") return true;
        if (answer == "n" || answer == "no") return false;
        Console.Write("Invalid response. Type 'y' for yes or 'n' for no: ");
    }
}

do
{
    PlayMatch();
} while (AskToRestart());
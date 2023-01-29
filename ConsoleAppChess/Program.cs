using System.Diagnostics;
using ConsoleAppChess;

string[,] board = new String[9, 9];

void Empty()
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            board[i, j] = Tile.Empty;
        }
    }
}

void NumberColumn()
{
    int counter = 8;
    for (int i = 0; i < 8; i++)
    {
        board[i, 8] = $" {counter} ";
        counter--;
    }
}

void LetterRow()
{
    board[8, 8] = "   ";
    board[8, 0] = " A ";
    board[8, 1] = " B ";
    board[8, 2] = " C ";
    board[8, 3] = " D ";
    board[8, 4] = " E ";
    board[8, 5] = " F ";
    board[8, 6] = " G ";
    board[8, 7] = " H ";
    //char letter = 'U+0041';
    //Console.OutputEncoding = System.Text.Encoding.UTF8;
    //for (int i = 0; i < 8; i++)
    //{
    //    board[i, 8] = $"  ";
    //    counter++;
    //}
}

void PiecesStartPosition()
{
    for (int i = 0; i < 8; i++)
    {
        board[1, i] = Tile.BlackPawn;
    }
    
    board[0, 0] = Tile.BlackRook;
    board[0, 1] = Tile.BlackKnight;
    board[0, 2] = Tile.BlackBishop;
    board[0, 3] = Tile.BlackQueen;
    board[0, 4] = Tile.BlackKing;
    board[0, 5] = Tile.BlackBishop;
    board[0, 6] = Tile.BlackKnight;
    board[0, 7] = Tile.BlackRook;

    for (int i = 0; i < 8; i++)
    {
        board[6, i] = Tile.WhitePawn;
    }

    //Piece WhiteRook;
    //WhiteRook.color = "white";
    //WhiteRook.columnPosition = 0;
    //WhiteRook.rowPosition = 7;
    
    board[7, 0] = Tile.WhiteRook;
    board[7, 1] = Tile.WhiteKnight;
    board[7, 2] = Tile.WhiteBishop;
    board[7, 3] = Tile.WhiteQueen;
    board[7, 4] = Tile.WhiteKing;
    board[7, 5] = Tile.WhiteBishop;
    board[7, 6] = Tile.WhiteKnight;
    board[7, 7] = Tile.WhiteRook;
}

void FillingTheBoard()
{
    Empty();
    NumberColumn();
    LetterRow();
    PiecesStartPosition();
}

string ConvertMove(string move)
{
    bool moveIsCorrect = true;
    while (moveIsCorrect)
    {
        char row = move[1];
        switch (row)
        {
            case '1':
            {
                move = move.Replace("1", "7");
                return move;
            }
            case '2':
            {
                move = move.Replace("2", "6");
                return move;
            }
            case '3':
            {
                move = move.Replace("3", "5");
                return move;
            }
            case '4':
            {
                move = move.Replace("4", "4");
                return move;
            }
            case '5':
            {
                move = move.Replace("5", "3");
                return move;
            }
            case '6':
            {
                move = move.Replace("6", "2");
                return move;
            }
            case '7':
            {
                move = move.Replace("7", "1");
                return move;
            }
            case '8':
            {
                move = move.Replace("8", "0");
                return move;
            }
            default:
            {
                Console.WriteLine("Incorrect wording. Try again!");
                moveIsCorrect = false;
                break;
            }
        }
    }

    moveIsCorrect = true;
    while (moveIsCorrect)
    {
        char column = move.ToLower()[0];
        switch (column)
        {
            case 'a':
            {
                move = move.Replace("a", "o");
                return move;
            }
            case 'b':
            {
                move = move.Replace("b", "1");
                return move;
            }
            case 'c':
            {
                move = move.Replace("c", "2");
                return move;
            }
            case 'd':
            {
                move = move.Replace("d", "3");
                return move;
            }
            case 'e':
            {
                move = move.Replace("e", "4");
                return move;
            }
            case 'f':
            {
                move = move.Replace("f", "5");
                return move;
            }
            case 'g':
            {
                move = move.Replace("g", "6");
                return move;
            }
            case 'h':
            {
                move = move.Replace("h", "7");
                return move;
            }
            default:
            {
                Console.WriteLine("Incorrect wording");
                moveIsCorrect = false;
                break;
            }
        }
    }
    return move;
}

void Move()
{
    string currentMoveStartPosition = Console.ReadLine();
    ConvertMove(currentMoveStartPosition);
    
    string currentMoveEndPosition = Console.ReadLine();
    ConvertMove(currentMoveEndPosition);
}

bool turnInProcess = true;
    while (turnInProcess)
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                if (i == 8 || j == 8)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }

                Console.Write(board[i, j]);
            }

            Console.WriteLine();
        }

        turnInProcess = false;
    }
FillingTheBoard();
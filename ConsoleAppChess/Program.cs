
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

int ConvertMove()
{
    
}
void MoveProcess(Move)
{
    string currentMoveStartTile = Console.ReadLine();
    string currentMoveEndTile = Console.ReadLine();
    char column = currentMoveStartTile.ToLower()[1];
    switch (column)
    {   
        case 'a':
        {
            column = '0';
            return;
        }
        case 'b':
        {
            column = '1';
            return;
        }
        case 'c':
        {
            column = '2';
            return;
        }
        case 'd':
        {
            column = '3';
            return;
        }
        case 'e':
        {
            column = '4';
            return;
        }
        case 'f':
        {
            column = '5';
            return;
        }
        case 'g':
        {
            column = '6';
            return;
        }
        case 'h':
        {
            column = '7';
            return;
        }
    }
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
            Console.Write(board[i,j]);
        }
        Console.WriteLine();
    }
    turnInProcess = false;
}

FillingTheBoard();

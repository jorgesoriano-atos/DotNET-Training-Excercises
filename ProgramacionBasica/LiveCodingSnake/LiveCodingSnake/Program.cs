

using LiveCodingSnake;
using System.Diagnostics;

Board board = new Board(20, 20);
Snake snake = new Snake(10, 10);
Nibble nibble = new Nibble(0, 0);

bool hasEaten = false;


do
{
    Console.Clear();
    board.DrawBoard();
    //Check if dead
    snake.IsDead(board);

    if (snake.IsAlive)
    {
        snake.Move(hasEaten);
        //Check if nibble was eaten
        hasEaten = snake.Eat(nibble, board);

        //Draw snek
        snake.DrawSnake();

        if (!board.HasNibble)
        {
            nibble = Nibble.AddNibble(snake, board);

        }

        //Draw nibble
        nibble.DrawNibble();

        //Get keystroke
        var sw = Stopwatch.StartNew();
        while (sw.ElapsedMilliseconds <= 200)
        {
            snake.Direction = ReadMovement(snake.Direction);
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Util.DrawPosition((board.Width / 2) - 5, board.Height / 2, "-GAME OVER-");
        Util.DrawPosition((board.Width / 2) - 4, (board.Height / 2) + 1, $"SCORE: {snake.Score}");
        Console.ResetColor();
    }

} while (snake.IsAlive);

Console.ReadKey();

static Direction ReadMovement(Direction currentMovement)
{
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey().Key;

        if(key == ConsoleKey.UpArrow && currentMovement != Direction.Down)
        {
            return Direction.Up;
        } else if(key == ConsoleKey.DownArrow && currentMovement != Direction.Up)
        {
            return Direction.Down;
        } else if(key == ConsoleKey.LeftArrow && currentMovement != Direction.Right)
        {
            return Direction.Left;
        } else if(key== ConsoleKey.RightArrow && currentMovement != Direction.Left)
        {
            return Direction.Right;
        }
    }
    return currentMovement;
}
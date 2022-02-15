using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSnake
{
    public class Snake
    {
        List<Position> Tail { get; set; }
        public Direction Direction { get; set; }
        public int Score { get; set; }
        public bool IsAlive { get; set; }

        public Snake(int x, int y)
        {
            Position defaultPosition = new Position(x, y);
            Tail = new List<Position>() { defaultPosition };
            Direction = Direction.Down;
            Score = 0;
            IsAlive = true;
        }

        public void DrawSnake()
        {
            foreach (Position position in Tail)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Util.DrawPosition(position.X, position.Y, "▒");
                Console.ResetColor();
            }
        }
        public void IsDead(Board board)
        {
            //Get head position
            Position headPosition = Tail.First();

            //Check if snake has hit itself or a wall.
            IsAlive = ! ((Tail.Count(pos => pos.X == headPosition.X && pos.Y == headPosition.Y) > 1)
                   || HasHitWall(board, Tail.First()));   

        }

        private bool HasHitWall(Board board, Position headPosition)
        {
            //Return true if head has hit any of the walls
            return headPosition.X == 0
                || headPosition.X == board.Width
                || headPosition.Y == 0
                || headPosition.Y == board.Height;
        }

        public void Move(bool hasEaten)
        {
            List<Position> newTail = new List<Position>();
            newTail.Add(GetNewDefaultPosition());
            newTail.AddRange(Tail);

            if (!hasEaten)
            {
                newTail.Remove(newTail.Last());
            }

            Tail = newTail;
        }

        private Position GetNewDefaultPosition()
        {
            int x = Tail.First().X;
            int y = Tail.First().Y;

            switch (Direction)
            {
                case Direction.Up:
                    y -= 1;
                    break;
                case Direction.Down:
                    y += 1;
                    break;
                case Direction.Left:
                    x -= 1;
                    break;
                case Direction.Right:
                    x += 1;
                    break;
            }

            return new Position(x, y);
        }

        public bool Eat(Nibble nibble, Board board)
        {
            /*
            - Increment lenght
            - Add to score
            - Delete previous nibble
             */
            if(IsPositionInTail(nibble.Position.X, nibble.Position.Y))
            {
                Score += 10;
                board.HasNibble = false;
                return true;
            }

            return false;
        }

        public bool IsPositionInTail(int x, int y)
        {
            return Tail.Any(p => p.X == x && p.Y == y);
        }

    }
}

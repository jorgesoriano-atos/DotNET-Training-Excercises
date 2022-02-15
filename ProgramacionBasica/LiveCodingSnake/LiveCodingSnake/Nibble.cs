using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSnake
{
    public class Nibble
    {
        public Position Position { get; set; }
        public Nibble(int x, int y)
        {
            Position = new Position(x, y);
        }

        public void DrawNibble()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Util.DrawPosition(Position.X, Position.Y, "☻");
            Console.ResetColor();
        }

        public static Nibble AddNibble(Snake snake, Board board)
        {
            bool positionValid = false;
            int x = 0;
            int y = 0;
            
            do
            {
                Random random = new Random();
                x = random.Next(1, board.Width);
                y = random.Next(1, board.Height);

                //position will be valid if not in tail.
                positionValid = !snake.IsPositionInTail(x, y);

            } while (!positionValid);

            board.HasNibble = positionValid;
            return new Nibble(x, y);
        }

    }

}

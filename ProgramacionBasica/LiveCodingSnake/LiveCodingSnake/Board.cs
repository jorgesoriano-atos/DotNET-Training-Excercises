using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSnake
{
    public class Board
    {
        public readonly int Height;
        public readonly int Width;
        public bool HasNibble;

        public Board(int height, int width)
        {
            Height = height;
            Width = width;
            HasNibble = false;
        }

        public void DrawBoard()
        {
            for (int i = 0; i <= Height ; i++)
            {
                //Draw right wall
                Util.DrawPosition(Height, i, "█");

                //Draw left wall
                Util.DrawPosition(0, i, "█");
            }

            for (int i = 0; i <= Width; i++)
            {
                //Draw bottom wall
                Util.DrawPosition(i, Width, "█");

                //Draw top wall
                Util.DrawPosition(i, 0, "█");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSnake
{
    static class Util
    {

        public static void DrawPosition(int x, int y, string character)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(character);

        }
    }
}

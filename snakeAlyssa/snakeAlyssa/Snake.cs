using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace snakeAlyssa
{
    public class Snake
    {
        int _x;
        int _y;
        int _width;
        int _height;
        public int Direction;
        //define a number as a direction
        /* left = 1 -> x-5
         * right = 2 -> x+5
         * up = 3 -> y-5
         * down = 4 -> y+5
         */

        public Snake(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public void Update()
        {
            if (Direction == 1)
            {
                _x -= 5;
            }

            if (Direction == 2)
            {
                _x += 5;
            }

            if (Direction == 3)
            {
                _y -= 5;
            }

            if (Direction == 4)
            {
                _y += 5;
            }
        }

        public void Render(Graphics gfx)
        {
            gfx.FillRectangle(new SolidBrush(Color.White), _x, _y, _width, _height);
        }
    }
}

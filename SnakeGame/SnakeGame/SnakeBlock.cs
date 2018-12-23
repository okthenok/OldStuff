using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class SnakeBlock : Block
    {
        int _direction = 0;
        //0 = up, 1 = left, 2 = down, 3 = right

        public int Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
            }
        }

        public void Move()
        {
            if (_direction == 0)
            {
                _y -= _diameter + 1;
            }
            if (_direction == 1)
            {
                _x -= _diameter+1;
            }
            if (_direction == 2)
            {
                _y += _diameter+1;
            }
            if (_direction == 3)
            {
                _x += _diameter+1;
            }
        }
    }
}

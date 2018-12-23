using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Snake
    {
        private List<SnakeBlock> _snakeList;

        public Snake()
        {
            _snakeList = new List<SnakeBlock>();
        }

        public List<SnakeBlock> SnakeList
        {
            get
            {
                return _snakeList;
            }
            set
            {
                _snakeList = value;
            }
        }
        
        public void Update(Graphics gfx)
        {
            foreach (SnakeBlock snakePiece in _snakeList)
            {
                snakePiece.Move();
            }


        }

        public void Erase(Graphics gfx)
        {
            foreach (SnakeBlock snakePiece in _snakeList)
            {
                snakePiece.Erase(gfx);
            }
        }

        public void Draw(Graphics gfx)
        {
            foreach (SnakeBlock snakePiece in _snakeList)
            {
                snakePiece.Draw(gfx);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Paddle
    {
        public int _x;
        public int _y;
        public int _width;
        public int _height;
        public Color _color;
        public Color _backcolor;
        //and this
        public Rectangle _boundingBox;

        public void Load(int x, int y, int width, int height, Color color, Color backcolor)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            _color = color;
            _backcolor = backcolor;

            //and this
            _boundingBox = new Rectangle(_x, _y, _width, _height);
        }

        //and this
        public void Update()
        {
            _boundingBox.X = _x;
            _boundingBox.Y = _y;
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(new SolidBrush(_color), _x, _y, _width, _height);
        }

        public void Erase(Graphics gfx)
        {
            gfx.FillRectangle(new SolidBrush(_backcolor), _x, _y, _width, _height);
        }
    }
}

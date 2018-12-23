using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Bouncing_Circle
{
    class Circle
    {
        public int _x;
        public int _y;
        public int _diameter;
        public int _xspeed;
        public int _yspeed;
        public Color _color;
        public Color _backcolor;

        public void Load(int x, int y, int diameter, int xspeed, int yspeed, Color color, Color backcolor)
        {
            _x = x;
            _y = y;
            _diameter = diameter;
            _xspeed = xspeed;
            _yspeed = yspeed;
            _backcolor = backcolor;
            _color = color;
        }

        public void Draw(Graphics gfx)
        {
            gfx.FillEllipse(new SolidBrush(_color), _x, _y, _diameter, _diameter);
        }
        public void Erase(Graphics gfx)
        {
            gfx.FillEllipse(new SolidBrush(_backcolor), _x, _y, _diameter, _diameter);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class Block
    {
        //TO DO: TURN THE PROPERTIES TO protected
        protected int _x;
        protected int _y;
        protected int _diameter;
        protected Color _color;
        protected Color _backcolor;
        protected Rectangle _boundingbox;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public int Diameter
        {
            get
            {
                return _diameter;
            }
            set
            {
                _diameter = value;
            }
        }
        public void Load(int x, int y, int diameter,  Color color, Color backcolor)
        {
            _x = x;
            _y = y;
            _diameter = diameter;
            _color = color;
            _backcolor = backcolor;
        }
        public Rectangle BoundingBox
        {
            get
            {
                return _boundingbox;
            }
        }
        public void Draw(Graphics gfx)
        {
            gfx.FillRectangle(new SolidBrush(_color), _x, _y, _diameter, _diameter);
        }

        public virtual void Update()
        {
            _boundingbox = new Rectangle(_x, _y, _diameter, _diameter);
        }

        public void Erase(Graphics gfx)
        {
            gfx.FillRectangle(new SolidBrush(_backcolor), _x, _y, _diameter, _diameter);
        }
        //something boundingbox
    }
}

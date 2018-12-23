using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Brick_Breaker
{
    public abstract class MovingSprite : Sprite
    {
        protected int xspeed=5;
        protected int yspeed=5;


        public int XSpeed
        {
            get
            {
                return xspeed;
            }
            set
            {
                xspeed = value;
            }
        }

        public int YSpeed
        {
            get
            {
                return yspeed;
            }
            set
            {
                yspeed = value;
            }
        }
    }
}

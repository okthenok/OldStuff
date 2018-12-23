using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Brick_Breaker
{
    class Paddle : MovingSprite
    {
        public void KeyboardMovement(KeyboardState ks, Keys leftKey, Keys rightKey)
        {
            if (ks.IsKeyDown(leftKey))
            {
                _position.X -= xspeed;
                _hitBox.X -= xspeed;
            }
            if (ks.IsKeyDown(rightKey))
            {
                _position.X += xspeed;
                _hitBox.X += xspeed;
            }
        }



    }
}

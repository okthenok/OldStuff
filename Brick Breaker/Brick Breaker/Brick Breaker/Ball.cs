using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brick_Breaker
{
    public class Ball : MovingSprite
    {
        public override void Update(Microsoft.Xna.Framework.GameTime gametime, Microsoft.Xna.Framework.Graphics.Viewport viewport)
        {
            _position.X += xspeed;
            _position.Y += yspeed;

            
            if (_position.X + _texture.Width > viewport.Width || _position.X < 0)
            {
                xspeed *= -1;
            }
            
            base.Update(gametime, viewport);
        }




    }
}

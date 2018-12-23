using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace Warmup
{
    class Paddle : Sprite
    {
        public void KeyboardMovement(KeyboardState ks, Keys upKey,Keys downKey)
        {
            if (ks.IsKeyDown(upKey))
            {
                _position.Y -= _yspeed;
                hitBox.Y -= _yspeed;
            }
            if (ks.IsKeyDown(downKey))
            {
                _position.Y += _yspeed;
                hitBox.Y += _yspeed;
            }
        }

        public void Update(GameTime gameTime)
        {
            hitBox = new Rectangle(X, Y, Width, Height);
        }
        
    }
}

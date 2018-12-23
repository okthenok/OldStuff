using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Warmup
{
    class Ball : Sprite
    {
        public string playername;
        public void Bounds(Viewport viewport)
        {
            if (_position.X > viewport.Width)
            {
                _position.X = 300;
                hitBox.X = 300;
                hitBox.Y = 25;
                _position.Y = 25;
                Game1.leftcounter++;
                if (Game1.leftcounter == 10)
                {
                    playername = "Kirby";
                    Game1.gameState = GameState.End;
                }
            }
            if (_position.X < 0)
            {
                _position.X = 300;
                hitBox.X = 300;
                hitBox.Y = 25;
                _position.Y = 25;
                Game1.rightcounter++;
                if (Game1.rightcounter == 10)
                {
                    playername = "Waddle Dee";
                    Game1.gameState = GameState.End;
                }
            }
            if (_position.Y + _texture.Height > viewport.Height || _position.Y < 0)
            {
                _yspeed *= -1;
            }
        }




        
    }
}

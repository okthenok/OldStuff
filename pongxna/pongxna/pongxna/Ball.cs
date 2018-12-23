using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace pongxna
{
    class Ball
    {
        Texture2D _texture;
        Vector2 _position;
        Color _tint;
        int _xspeed;
        int _yspeed;

        public void Load(Texture2D texture, Vector2 position, Color tint, int xspeed,int yspeed)
        {
            _texture = texture;
            _position = position;
            _tint = tint;
            _xspeed = xspeed;
            _yspeed = yspeed;
        }
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, _position, _tint);
        }
        public void Move(GameTime gameTime)
        {
            _position.X += _xspeed;
            _position.Y += _yspeed;
        }
    }
}

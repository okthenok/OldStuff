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

namespace Brick_Breaker
{
    public class Sprite
    {
        protected Texture2D _texture;
        protected Vector2 _position;
        protected Color _tint;
        protected Rectangle _hitBox;
        

        public Rectangle HitBox
        {
            get
            {
                return _hitBox;
            }
            set
            {
                _hitBox = value;
            }

        }
        public virtual void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, _position, _tint);
            
        }
        public void Load(Texture2D texture, Vector2 position, Color tint, int xspeed, int yspeed)
        {
            _texture = texture;
            _position = position;
            _tint = tint;
            _hitBox = new Rectangle((int)_position.X, (int)_position.Y, _texture.Width, _texture.Height);
        }

        public virtual void Update(GameTime gametime, Viewport viewport)
        {
            _hitBox = new Rectangle((int)_position.X, (int)_position.Y, _texture.Width, _texture.Height);
        }

        public int X
        {
            get
            {
                return (int)_position.X;
            }
            set
            {
                _position.X = value;
            }
        }
        public int Y
        {
            get
            {
                return (int)_position.Y;
            }
            set
            {
                _position.Y = value;
            }
        }
        public int Height
        {
            get
            {
                return _texture.Bounds.Height;
            }
        }
        public int Width
        {
            get
            {
                return _texture.Bounds.Width;
            }
        }
        
    }
}

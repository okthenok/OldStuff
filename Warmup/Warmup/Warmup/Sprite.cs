using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace Warmup
{
    class Sprite
    {
        protected Texture2D _texture;
        protected Vector2 _position;
        protected Color _tint;
        protected int _xspeed;
        protected int _yspeed;
        protected Rectangle hitBox;
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
        public Rectangle HitBox
        {
            get
            {
                return hitBox;
            }
            set
            {
                hitBox = value;
            }

        }
        
        public int xspeed
        {
            get
            {
                return _xspeed;
            }
            set
            {
                _xspeed = value;
            }
        }

        public int yspeed
        {
            get
            {
                return _yspeed;
            }
            set
            {
                _yspeed = value;
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
        public int HitBoxY
        {
            get
            {
                return hitBox.Y;
            }
            set
            {
                hitBox.Y = value;
            }
        }


        public void Load(Texture2D texture, Vector2 position, Color tint, int xspeed, int yspeed)
        {
            _texture = texture;
            _position = position;
            _tint = tint;
            _xspeed = xspeed;
            _yspeed = yspeed;
            hitBox = new Rectangle((int)_position.X,(int) _position.Y, _texture.Width,_texture.Height);

            
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, _position, _tint);
        }
        public void Move(GameTime gameTime)
        {
            _position.X += _xspeed;
            _position.Y += _yspeed;
            hitBox.X = Convert.ToInt32(_position.X);
            hitBox.Y = Convert.ToInt32(_position.Y);
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace WindowsGame3
{
    class Sprite
    {
        protected Texture2D _texture;
        protected Vector2 _position;

        public virtual float X
        {
            get
            {
                return _position.X;
            }
            set
            {
                _position.X = value;
            }
        }
        public virtual float Y
        {
            get
            {
                return _position.Y;
            }
            set
            {
                _position.Y = value;
            }
        }
        public virtual Vector2 Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        protected Rectangle _sourceRectangle;
        protected Color _color;
        protected Rectangle _hitbox;

        public Rectangle Hitbox
        {
            get
            {
                return _hitbox;
            }
        }

        public Sprite(Texture2D texture, Vector2 position, Color color)
            : this(texture, position, new Rectangle(0, 0, texture.Width, texture.Height), color)
        {
        }

        public Sprite(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color)
        {
            _texture = texture;
            _position = position;
            _color = color;
            _hitbox = new Rectangle((int)position.X, (int)position.Y, sourceRectangle.Width, sourceRectangle.Height);
            _sourceRectangle = sourceRectangle;
        }

        public virtual void Update(GameTime gameTime)
        {
            _hitbox.Location = new Point((int)_position.X, (int)_position.Y);
        }

        public virtual void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, _position, _sourceRectangle, _color);
            //HitBox Draw
            //spritebatch.Draw(_texture, _hitbox, Color.Purple);
        }

    }
}

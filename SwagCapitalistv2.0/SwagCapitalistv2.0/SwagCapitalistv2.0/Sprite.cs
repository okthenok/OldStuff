using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SwagCapitalistv2._0
{
    public class Sprite
    {
        protected bool isVisible = true;

        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }

        protected Rectangle _hitbox;

        public Rectangle Hitbox
        {
            get
            {
                return _hitbox;
            }
        }

        protected Texture2D _texture;
        protected Vector2 _position;
        protected Color _color;
        protected Rectangle _sourceRectangle;

        public Sprite(Texture2D texture, Vector2 position, Color color)
        {
            _texture = texture;
            _position = position;
            _color = color;
        }

        public Sprite(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color)
        {
            _texture = texture;
            _position = position;
            _color = color;
            _sourceRectangle = sourceRectangle;
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

        public virtual void Update(GameTime gametime)
        {

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, _position, _color);
        }
    }
}

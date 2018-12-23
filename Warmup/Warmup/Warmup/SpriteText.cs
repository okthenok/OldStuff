using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Warmup
{
    public class SpriteText
    {
        SpriteFont _font;
        string _text;
        Vector2 _position;
        Color _tint = Color.White;

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        public void Load(SpriteFont font, string text,  Vector2 position, Color tint)
        {
            _font = font;
            _position = position;
            _tint = tint;
            _text = text;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_font, _text, _position, _tint);
        }
    }
}

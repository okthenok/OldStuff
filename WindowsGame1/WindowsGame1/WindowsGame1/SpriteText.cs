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

namespace WindowsGame1
{
    class SpriteText
    {
        SpriteFont _font;
        public string _text;
        Vector2 _position;
        Color _color;
        public Rectangle rekt;

        public void Load(SpriteFont font, string text, Vector2 position, Color color)
        {
            _font = font;
            _text = text;
            _position = position;
            _color = color;
            rekt = new Rectangle((int)position.X, (int)position.Y, (int)_font.MeasureString(text).X, (int)_font.MeasureString(text).Y);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_font, _text, _position, _color);
        }

        public SpriteFont Font
        {
            get
            {
                return _font;
            }
            set
            {
                _font = value;
            }
        }
    }
}

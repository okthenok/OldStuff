using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SwagCapitalistv2._0
{
    public class Button : Sprite
    {
        //variables
        public bool Clicked;
        MouseState ms;
        MouseState lms;

        //functions
        public Button(Texture2D image, Vector2 position, Color color) 
            : base(image, position, color)
        {
        
        }

        public Button(Texture2D image, Vector2 position, Rectangle sourceRectangle, Color color)
            : base(image, position, sourceRectangle, color)
        
        {
            _hitbox = new Rectangle((int)_position.X, (int)_position.Y, _sourceRectangle.Width, _sourceRectangle.Height);
        }

        public override void Update(GameTime gameTime)
        {
            ms = Mouse.GetState();
            _hitbox = new Rectangle((int)_position.X, (int)_position.Y, _sourceRectangle.Width, _sourceRectangle.Height);
            //_hitbox = new Rectangle((int)_position.X, (int)_position.Y, _texture.Width, _texture.Height);
            if (isVisible)
            {
                if (ms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed && lms.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
                {
                    if (Hitbox.Contains(ms.X, ms.Y))
                    {
                        Clicked = true;

                    }
                    else
                    {
                        Clicked = false;
                    }
                }
                else
                {
                    Clicked = false;
                }
            }
            lms = ms;
            base.Update(gameTime);
        }
    }
}

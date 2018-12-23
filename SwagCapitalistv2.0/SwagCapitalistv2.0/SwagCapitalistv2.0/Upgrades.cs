using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SwagCapitalistv2._0
{
    class Upgrades : Button
    {
        public Upgrades(Texture2D image, Vector2 position, Color color)
            : base(image, position, color)
        {

        }
        public Upgrades(Texture2D image, Vector2 position, Rectangle sourceRectangle, Color color)
            : base(image, position, sourceRectangle, color)
        {
            _hitbox = new Rectangle((int)_position.X, (int)_position.Y, _sourceRectangle.Width, _sourceRectangle.Height);
        }
    }
}

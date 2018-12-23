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
    class Ally : Ship
    {
        public Ally(Texture2D texture, Vector2 position, Color color, int damage, int health)
            : base(texture, position, color, damage, health)
        {
        }
        public Ally(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, int damage, int health)
            : base(texture, position, sourceRectangle, color, damage, health)
        {
        }
    }
}

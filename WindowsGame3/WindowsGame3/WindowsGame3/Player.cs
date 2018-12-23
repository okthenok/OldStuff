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
    class Player : Ally
    {
        public Player(Texture2D texture, Vector2 position, Color color, int playerhealth, int damage, int health)
            : base(texture, position, color, damage, health)
        {
        }
    }
}

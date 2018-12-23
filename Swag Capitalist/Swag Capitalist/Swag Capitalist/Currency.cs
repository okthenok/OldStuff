using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Swag_Capitalist
{
    public class Currency : Sprite
    {
        public Currency(Texture2D texture, Vector2 position, Color color)
            :base(texture,position,color)
        {
            _texture = texture;
            _position = position;
            _color = color;
        }

        int money;
        public int Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        //kappa
        //smorc
        //babyrage
        //biblethump
        //residentsleeper
        //failfish
        //pogchamp
        //abe
    }
}

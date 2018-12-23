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
    class Boss : Enemy
    {
        RectangleF[] _hitBoxes;

        public RectangleF[] HitBoxes
        {
            get
            {
                return _hitBoxes;
            }
        }

        public override Vector2 Position
        {
            get
            {
                return base.Position;
            }
            set
            {
                Vector2 difference = value - _position;
                base.Position = value;
                for (int i = 0; i < _hitBoxes.Length; i++)
                {
                    _hitBoxes[i].X += difference.X;
                    _hitBoxes[i].Y += difference.Y;
                }
            }
        }

        public override float X
        {
            get
            {
                
                return base.X;
            }
            set
            {
                float difference = value - _position.X;
                base.X = value;
                for (int i = 0; i < _hitBoxes.Length; i++)
                {
                    _hitBoxes[i].X += difference;
                }
            }
        }

        public override float Y
        {
            get
            {
                return base.Y;
            }
            set                
            {
                float difference = value - _position.Y;
                base.Y = value;
                for (int i = 0; i < _hitBoxes.Length; i++)
                {
                    _hitBoxes[i].Y += difference;
                }
            }
        }

        public Boss(Texture2D texture, Vector2 position, Color color, int damage, int health, List<RectangleF> hitBoxes)
            : base(texture, position, color, damage, health)
        {
            _hitBoxes = hitBoxes.ToArray();
            for (int i = 0; i < _hitBoxes.Length; i++)
            {
                _hitBoxes[i].X += _position.X;
                _hitBoxes[i].Y += _position.Y;
            }
        }

        public Boss(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, int damage, int health, List<RectangleF> hitBoxes)
            : base(texture, position, sourceRectangle, color, damage, health)
        {
            _hitBoxes = hitBoxes.ToArray();
            for (int i = 0; i < _hitBoxes.Length; i++)
            {
                _hitBoxes[i].X += _position.X;
                _hitBoxes[i].Y += _position.Y;
            }
        }
    }
}

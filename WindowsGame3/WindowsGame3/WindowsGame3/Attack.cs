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
    class Attack : Sprite
    {
        protected Team _team;
        protected int _damage;
        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        

        protected bool _fire;

        public Team Team
        {
            get
            {
                return _team;
            }
            set
            {
                _team = value;
            }
        }


        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }

        public Attack(Texture2D texture, Vector2 position, Color color, int speed, int damage, Team team)
            :   base(texture, position, color)
        {
            _team = team;
            _speed = speed;
            _damage = damage;
            _fire = false;
        }

        public override void Update(GameTime gameTime)
        {
            if (Team == WindowsGame3.Team.Enemy)
            {
                _position.Y += _speed;
            }
            else
            {
                _position.Y -= _speed;
            }
            base.Update(gameTime);
        }
    }
}

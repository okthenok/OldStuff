using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace WindowsGame3
{
    class Ship : Sprite
    {
        protected HealthStatus _healthStatus;

        public HealthStatus HealthStatus
        {
            get
            {
                return _healthStatus;
            }
        }

        protected int _health;
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (_health <= 0)
                {
                    _healthStatus = HealthStatus.Dead;
                }
                else if ((float)_health / _maxHealth <= .3f)
                {
                    _healthStatus = HealthStatus.LowHealth;
                }
                else
                {
                    _healthStatus = HealthStatus.HighHealth;
                }
            }
        }

        protected int _maxHealth;

        int _damage;

        public Ship(Texture2D texture, Vector2 position, Color color, int damage, int health)
            : base(texture, position, color)
        {
            _damage = damage;
            _health = health;
            _maxHealth = health;
        }

        public Ship(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, int damage, int health)
            : base(texture, position, sourceRectangle, color)
        {
            _damage = damage;
            _health = health;
            _maxHealth = health;
        }
        public override void Draw(SpriteBatch spritebatch)
        {
            if (HealthStatus != HealthStatus.Dead)
            {
                base.Draw(spritebatch);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Brick_Breaker
{
    class Brick
    {
        private List<Sprite> _Bricklist;

        public List<Sprite> list
        {
            get
            {
                return _Bricklist;
            }
        }
        public Brick()
        {
            _Bricklist = new List<Sprite>();
        }

        public void Add(Sprite sprite)
        {
            _Bricklist.Add(sprite);
        }
        public void Remove(Sprite sprite)
        {
            _Bricklist.Remove(sprite);
        }

        public void Update(GameTime gametime, Viewport viewport)
        {
            foreach (Sprite sprite in _Bricklist)
            {
                sprite.Update(gametime, viewport);
            }
        }
        public void Draw(SpriteBatch spritebatch)
        {
            foreach (Sprite sprite in _Bricklist)
            {
                sprite.Draw(spritebatch);
            }
        }
    }
}

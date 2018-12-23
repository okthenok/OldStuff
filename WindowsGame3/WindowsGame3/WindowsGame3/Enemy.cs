using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace WindowsGame3
{
    class Enemy : Ship
    {
        Vector2 moveTo;
        Vector2 normalizedSpeed;

        public Enemy(Texture2D texture, Vector2 position, Color color, int damage, int health)
            : base(texture, position, color, damage, health)
        {
            moveTo = new Vector2(RandomGenerator.randomGenerator.Next(GraphicsManager.ScreenWidth - texture.Width), RandomGenerator.randomGenerator.Next(GraphicsManager.ScreenHeight/2));
            normalizedSpeed = position - moveTo;
            normalizedSpeed.Normalize();
        }

        public Enemy(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, int damage, int health)
            : base(texture, position, sourceRectangle, color, damage, health)
        {
            moveTo = new Vector2(RandomGenerator.randomGenerator.Next(GraphicsManager.ScreenWidth - sourceRectangle.Width), RandomGenerator.randomGenerator.Next(GraphicsManager.ScreenHeight / 2));
            normalizedSpeed = position - moveTo;
            normalizedSpeed.Normalize();
        }

        public override void Update(GameTime gameTime)
        {
            Position -= normalizedSpeed;
            if (Vector2.DistanceSquared(Position, moveTo) < 1)
            {
                moveTo = new Vector2(RandomGenerator.randomGenerator.Next(GraphicsManager.ScreenWidth - _sourceRectangle.Width), RandomGenerator.randomGenerator.Next(GraphicsManager.ScreenHeight / 2));
                normalizedSpeed = Position - moveTo;
                normalizedSpeed.Normalize();
            }
            /*if (normalizedSpeed.X < 0 && _position.X < moveTo.X)
            {
                if (normalizedSpeed.Y < 0 && _position.Y < moveTo.Y ||
                    normalizedSpeed.Y > 0 && _position.Y > moveTo.Y)
                {
                    moveTo = new Vector2(RandomGenerator.randomGenerator.Next(GraphicsManager.ScreenWidth - _sourceRectangle.Width), RandomGenerator.randomGenerator.Next(GraphicsManager.ScreenHeight / 2));
                    normalizedSpeed = _position - moveTo;
                    normalizedSpeed.Normalize();
                }
            }
            else if (normalizedSpeed.X > 0 && _position.X > moveTo.X)
            {
                if (normalizedSpeed.Y < 0 && _position.Y < moveTo.Y ||
                    normalizedSpeed.Y > 0 && _position.Y > moveTo.Y)
                {
                    moveTo = new Vector2(RandomGenerator.randomGenerator.Next(GraphicsManager.ScreenWidth - _sourceRectangle.Width), RandomGenerator.randomGenerator.Next(GraphicsManager.ScreenHeight / 2));
                    normalizedSpeed = _position - moveTo;
                    normalizedSpeed.Normalize();
                }
            }*/
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            //movement position
            //spritebatch.Draw(_texture, moveTo, _sourceRectangle, Color.Purple);
            base.Draw(spritebatch);
        }
    }
}

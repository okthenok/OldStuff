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

namespace Brick_Breaker
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Ball ball;
        Paddle paddle;
        Brick bricks;
        Sprite brick;

        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            
        }
        

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ball = new Ball();
            ball.Load(Content.Load<Texture2D>("Ball"), new Vector2(360, 395), Color.White, 3, 3);
            paddle = new Paddle();
            bricks = new Brick();
            int x = 7;
            int y = 0;
            Texture2D brickimage = Content.Load<Texture2D>("Brick");
            for (int row = 0; row < 4; row++)
            {
                for (int i = 0; i < 8; i++)
                {
                    brick = new Sprite();
                    brick.Load(brickimage, new Vector2(x, y), Color.Cyan, 0, 0);
                    bricks.Add(brick);
                    x += brickimage.Width + 5;
                }
                x = 7;
                y += brickimage.Height + 10;
            }
            paddle.Load(Content.Load<Texture2D>("Platform"), new Vector2(275, 445), Color.White, 3, 3);
            // TODO: use this.Content to load your game content here
            paddle.Y = GraphicsDevice.Viewport.Height - paddle.Height;
        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        protected override void Update(GameTime gameTime)
        {
            KeyboardState ks;
            ks = Keyboard.GetState();
            ball.Update(gameTime, GraphicsDevice.Viewport);
            paddle.Update(gameTime, GraphicsDevice.Viewport);

                if (ball.HitBox.Intersects(paddle.HitBox))
                {
                    if (ball.YSpeed > 0)
                    {
                        ball.Y -= 10;
                        ball.YSpeed *= -1;
                    }
                    else if (paddle.X + paddle.Width <= ball.X + ball.Width / 2)
                    {
                        ball.Y -= 5;
                        ball.X += 5;
                        ball.XSpeed = Math.Abs(ball.XSpeed);
                        ball.YSpeed = Math.Abs(ball.YSpeed) * -1;
                    }
                    else if (paddle.X + paddle.Width >= ball.X + ball.Width / 2)
                    {
                        ball.Y += 5;
                        ball.X -= 5;
                        ball.XSpeed = Math.Abs(ball.XSpeed);
                        ball.YSpeed = Math.Abs(ball.YSpeed) * -1;
                    }
                }
            //foreach loop doesn't allow you to make any changes to your list
                //must use a for loop instead #ariaisdabes
            for(int i = 0; i < bricks.list.Count; i++)
            {
                if (ball.HitBox.Intersects(bricks.list[i].HitBox))
                {
                    if (ball.Y < bricks.list[i].Y + bricks.list[i].Height - 5)
                    {
                        if (ball.YSpeed > 0)
                        {
                            ball.X -= 10;
                            ball.XSpeed *= -1;
                        }
                        else
                        {
                            ball.X += 10;
                            ball.XSpeed *= -1;
                        }
                    }
                    else
                    {
                        if (ball.YSpeed < 0)
                        {
                            ball.YSpeed *= -1;
                        }
                    }
                    bricks.list.Remove(bricks.list[i]);
                }
            }
            paddle.KeyboardMovement(ks, Keys.Left, Keys.Right);
            paddle.X = (int)MathHelper.Clamp(paddle.X, 0, GraphicsDevice.Viewport.Width - paddle.Width);
            bricks.Update(gameTime, GraphicsDevice.Viewport);
            paddle.Update(gameTime, GraphicsDevice.Viewport);
            // TODO: Add your update logic here

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            ball.Draw(spriteBatch);
            paddle.Draw(spriteBatch);
            bricks.Draw(spriteBatch);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

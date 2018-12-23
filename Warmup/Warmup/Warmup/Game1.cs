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

namespace Warmup
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        KeyboardState ks;
        Ball ball;
        Paddle waddleDee;
        Paddle kirby;
        SpriteText scoreText;
        Sprite RedCircle;
        
        public static int leftcounter = 0;
        public static int rightcounter = 0;
        Texture2D pixel;
        public static GameState gameState = GameState.Start;


        public static bool isPlaying = true;
        public static bool isDone = false;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            kirby = new Paddle();
            waddleDee = new Paddle();
            ball= new Ball();
            //you are missing a ball class a paddle class >.>
            spriteBatch = new SpriteBatch(GraphicsDevice);
            scoreText = new SpriteText();
            scoreText.Load(Content.Load<SpriteFont>("font"), string.Format("{0} - Score - {1}", leftcounter, rightcounter), new Vector2(GraphicsDevice.Viewport.Width / 2, 0), Color.White);
            kirby.Load(Content.Load<Texture2D>("SwordKirby"), new Vector2(0,0), Color.White, 0, 5);
            waddleDee.Load(Content.Load<Texture2D>("WaddleDee"), new Vector2(720, 0), Color.White, 0, 5);
            ball.Load(Content.Load<Texture2D>("Kirby Ball"), new Vector2(300, 25), Color.White, 5, 5);
            IsMouseVisible = true;
            RedCircle = new Sprite();
            RedCircle.Load(Content.Load<Texture2D>("RedCircle"), new Vector2(100, 100), Color.White, 0, 0);

            // TODO: use this.Content to load your game content here
        }


        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            if (gameState == GameState.Playing)
            {
                ball.Move(gameTime);
                ball.Bounds(GraphicsDevice.Viewport);
                if (kirby.HitBox.Intersects(ball.HitBox) && ball.xspeed < 0)
                {
                    ball.xspeed *= -1;
                }
                if (waddleDee.HitBox.Intersects(ball.HitBox) && ball.xspeed > 0)
                {
                    ball.xspeed *= -1;
                }

                //I DUNNO WHATTA DO
                scoreText.Text = string.Format("{0} - Score - {1}", leftcounter, rightcounter);
                kirby.KeyboardMovement(ks, Keys.W, Keys.S);
                waddleDee.KeyboardMovement(ks, Keys.Up, Keys.Down);
                kirby.Y = (int)MathHelper.Clamp(kirby.Y, 0, GraphicsDevice.Viewport.Height - kirby.Height);
                waddleDee.Y = (int)MathHelper.Clamp(waddleDee.Y, 0, GraphicsDevice.Viewport.Height - waddleDee.Height);
                kirby.Update(gameTime);
                waddleDee.Update(gameTime);
                base.Update(gameTime);

                if (ks.IsKeyDown(Keys.P))
                {
                    gameState = GameState.Pause;
                    scoreText.Text = string.Format("Paused! Press O to resume!");
                }
                
            }
            if (gameState == GameState.Start)
            {

            }
            if (gameState == GameState.Pause)
            {
                if (ks.IsKeyDown(Keys.O))
                {
                    gameState = GameState.Playing;
                }
            }
            if (gameState == GameState.End)
            {
                scoreText.Text = string.Format("Game over! {0} wins!",ball.playername);
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            if (gameState == GameState.Playing || gameState == GameState.Pause)
            {
                kirby.Draw(spriteBatch);
                waddleDee.Draw(spriteBatch);
                ball.Draw(spriteBatch);
                scoreText.Draw(spriteBatch);
            }
            if (gameState == GameState.End)
            {
                scoreText.Draw(spriteBatch);
            }
            if (gameState == GameState.Start)
            {
                RedCircle.Draw(spriteBatch);
            }
            
            //spriteBatch.Draw(pixel, kirby.HitBox, Color.Red);
            //spriteBatch.Draw(pixel, Ball.HitBox, Color.Red);
            //spriteBatch.Draw(pixel, waddleDee.HitBox, Color.Red);

            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

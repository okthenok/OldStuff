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

namespace introtoxna
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D image;
        Color tint;
        Vector2 position;
        int speedX = 5;
        int speedY = 5;


        KeyboardState keyboardState;




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
            spriteBatch = new SpriteBatch(GraphicsDevice);
            image = Content.Load<Texture2D>("kirby");
            tint = Color.White;
            position = new Vector2(0, 0);
            IsMouseVisible = true;
            // TODO: use this.Content to load your game content here
        }

        
      
        protected override void Update(GameTime gameTime)
        {
            keyboardState = Keyboard.GetState();

            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
                
            // TODO: Add your update logic here
            //position.X += speedX;
            //position.Y += speedY;
            //if (position.X + image.Width > GraphicsDevice.Viewport.Width || position.X < 0)
            //{
            //    speedX *= -1;
            //}
            //(>-_-)> noooooooooooooooo kirby died
            //if (position.Y + image.Height > GraphicsDevice.Viewport.Height || position.Y < 0)
            //{
            //    speedY *= -1;
            //}

            if (keyboardState.IsKeyDown(Keys.A))
            {
                position.X -= speedX;
            }
            if(keyboardState.IsKeyDown(Keys.D))
            {
                position.X += speedX;
            }
            if (keyboardState.IsKeyDown(Keys.W))
            {
                position.Y -= speedY;
            }
            if (keyboardState.IsKeyDown(Keys.S))
            {
                position.Y += speedY;
            }

            if (position.Y + image.Height <= 0)
            {
                position = new Vector2(position.X, GraphicsDevice.Viewport.Height - 1);
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(image, position, tint);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

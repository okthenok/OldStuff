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

namespace SwagCapitalistv2._0
{
    
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont font;

        MouseState ms;
        Sprite background;
        Sprite cursor;
        
        Button swagChest;
        Button help;

        Manager myGame;
        Currency counter;
        PlayerStats stats;
        List<SwagProducer> buttons = new List<SwagProducer>();
        Producers producers;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            graphics.PreferredBackBufferHeight = 800;
            graphics.PreferredBackBufferWidth = 1000;
            graphics.ApplyChanges();
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = Content.Load<SpriteFont>("SpriteFont1");

            background = new Sprite(Content.Load<Texture2D>("swagBack"), new Vector2(0, 0), Color.White);
            cursor = new Sprite(Content.Load<Texture2D>("cursor"), new Vector2(0, 0), Color.White);
            swagChest = new Button(Content.Load<Texture2D>("swagBack"), new Vector2(353, 76), new Rectangle(353, 76, 268, 213), Color.White);
            help = new Button(Content.Load<Texture2D>("swagBack"), new Vector2(874, 674), new Rectangle(874, 674, 119, 119), Color.White);
            counter = new Currency();
            stats = new PlayerStats();
            buttons.Add(new SwagProducer(Content.Load<Texture2D>("swagBack"), new Vector2(89, 299), Color.White, new Rectangle(89, 299, 361, 114)));
            

            myGame = new Manager(spriteBatch);
            myGame.LoadContent(font, stats);
            // TODO: use this.Content to load your game content here
        }

        
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        
        protected override void Update(GameTime gameTime)
        {
            ms = Mouse.GetState();
            cursor.Position = new Vector2(ms.X, ms.Y);
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            #region Converting
            if (stats.Kappa >= 100)
            {
                stats.Kappa = 0;
                stats.Smorc += 1;
            }
            if (stats.Smorc >= 100)
            {
                stats.Smorc = 0;
                stats.Babyrage += 1;
            }
            if (stats.Babyrage >= 100)
            {
                stats.Babyrage = 0;
                stats.Biblethump += 1;
            }
            if (stats.Biblethump >= 100)
            {
                stats.Biblethump = 0;
                stats.Residentsleeper += 1;
            }
            if (stats.Residentsleeper >= 100)
            {
                stats.Residentsleeper = 0;
                stats.Failfish += 1;
            }
            if (stats.Failfish >= 100)
            {
                stats.Failfish = 0;
                stats.Pogchamp += 1;
            }
            if (stats.Pogchamp >= 100)
            {
                stats.Pogchamp = 0;
                stats.SwagAbe += 1;
            }
#endregion

            for (int i = 0; i < buttons.Count; i++)
            {
                if (i == 1)
                {
                    producers = Producers.abe;
                }
                //TODO: STUFF AND THINGS
                //actually just cycle through to see if they were clicked and stuff and then do stuff with the enums and stuff like that and stuff
                //stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff stuff
            }

            if (help.Clicked)
            {
                
            }
            if (swagChest.Clicked)
            {
                stats.Kappa += 1;
            }
            
            stats.Biblethump = stats.Abe * stats.AbeValue;
            //through every producer
            //totalPoints += numOfAbes * valueOfAbe;

            swagChest.Update(gameTime);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            // TODO: Add your drawing code here
            background.Draw(spriteBatch);

            myGame.Draw();
            //spriteBatch.DrawString(font, counter.Money.ToString(), new Vector2(730, 75), Color.Black);

            cursor.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

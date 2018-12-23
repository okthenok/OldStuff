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

namespace Swag_Capitalist
{
    
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteFont font;
        SpriteBatch spriteBatch;
        MouseState ms;
        Sprite background;
        Sprite cursor;
        TimeSpan oneSecond = TimeSpan.FromMilliseconds(1000);
        TimeSpan counter = new TimeSpan();
        #region stuff
        Currency kappa;
        Currency smorc;
        Currency babyrage;
        Currency biblethump;

        SwagProducer swagChest;
        SwagProducer sunglasses;
        SwagProducer helloKittyKeychains;
        SwagProducer fullGrownBeard;
        SwagProducer sparkles;
        SwagProducer halo;
        SwagProducer snapBack;
        SwagProducer goldSuit;
        SwagProducer abe;

        double sunglassesCost = 100;
        double hkKeychainsCost = 350;
        double fgBeardCost = 1000;
        double sparklesCost = 2500;
        double haloCost = 6000;
        double goldSuitCost = 12000;
        double abeCost = 99999;
        double multiplierPerBuy = 1.15;

        #endregion
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            graphics.PreferredBackBufferHeight = 800;
            graphics.PreferredBackBufferWidth = 1000;
            graphics.ApplyChanges();

            spriteBatch = new SpriteBatch(GraphicsDevice);

            background = new Sprite(Content.Load<Texture2D>("swagBack"), new Vector2(0, 0), Color.White);
            cursor = new Sprite(Content.Load<Texture2D>("cursor"), new Vector2(0, 0), Color.White);
            font = Content.Load<SpriteFont>("spritefont1");
            kappa = new Currency(Content.Load<Texture2D>("kappa"), new Vector2(680,80), Color.White);
            swagChest = new SwagProducer(Content.Load<Texture2D>("swagBack"), new Vector2(353, 76), new Rectangle(353, 76, 268, 213), Color.White);
            sunglasses = new SwagProducer(Content.Load<Texture2D>("swagBack"), new Vector2(89, 299), new Rectangle(89, 299, 361, 114), Color.White);
            
        }

        
        
        protected override void Update(GameTime gameTime)
        {
            counter += gameTime.ElapsedGameTime;


            ms = Mouse.GetState();
            cursor.Position = new Vector2(ms.X, ms.Y);
            // TODO: Add your update logic here
            swagChest.Update(gameTime);
            sunglasses.Update(gameTime);
            swagChest.IsVisible = true;
            
            if (swagChest.Clicked)
            {
                kappa.Money += 1;
            }
            if (sunglasses.Clicked && kappa.Money >= sunglassesCost)
            {
                if (sunglasses.Activated == false)
                {
                    kappa.Money -= (int)sunglassesCost;
                    sunglasses.Activated = true;
                    sunglasses.NumberOfProducers += 1;
                }
                else if (sunglasses.Activated && kappa.Money >= sunglassesCost * multiplierPerBuy)
                {
                    sunglassesCost *= multiplierPerBuy;
                    kappa.Money -= (int)sunglassesCost;
                    sunglasses.NumberOfProducers += 1;
                    sunglasses.SwagPerSecond = 2;
                    sunglasses.SwagPerSecond *= sunglasses.NumberOfProducers;
                }
            }
            if (sunglasses.Activated)
            {
                if (oneSecond < counter)
                {
                    kappa.Money += sunglasses.SwagPerSecond;
                    counter = new TimeSpan();
                }
            }




            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            // TODO: Add your drawing code here
            background.Draw(spriteBatch);
            //IN CHALLENJOUR BACKGROUNDS APPEAR FIRST, AND UR DRWINGS HAPPEN IN ORDER OF PRECEDENCEEEEE WHATEVER IS DRAWN FIRST GOES ON THE BOTTOM AND STACKS
            
            spriteBatch.DrawString(font, ":" + kappa.Money.ToString(), new Vector2(750, 75), Color.Black);
            //spriteBatch.DrawString(font, ":" + 
            cursor.Draw(spriteBatch);
            kappa.Draw(spriteBatch);


            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

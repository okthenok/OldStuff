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
using System.Diagnostics;

namespace WindowsGame3
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player player;
        Boss first;
        TimeSpan shootTime = TimeSpan.FromMilliseconds(175);
        TimeSpan elaspedShootTime = new TimeSpan();
        TimeSpan animationTime = TimeSpan.FromMilliseconds(250);
        TimeSpan elaspedAnimationTime = new TimeSpan();
        TimeSpan enemyShootTime = TimeSpan.FromMilliseconds(500);
        TimeSpan enemyElaspedShootTime = new TimeSpan();
        TimeSpan enemyAnimationTime = TimeSpan.FromMilliseconds(300);

        List<Attack> attacks = new List<Attack>();
        List<Rectangle> enemyShipsRectangles = new List<Rectangle>();
        List<Enemy> ships = new List<Enemy>();
        
        Texture2D enemyShipsTexture;
        int currentShip = 0;
        bool isShooting = false;
        //create a bool called isshooting, should be false by default

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            GraphicsManager.Initialize(graphics);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {


            base.Initialize();
        }


        protected override void LoadContent()
        {
            GraphicsManager.ScreenHeight = 1000;
            GraphicsManager.ScreenWidth = 900;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Player(Content.Load<Texture2D>("spaceship"), new Vector2(400, 900), Color.White, 10000, 500, 10);
            first = new Boss(Content.Load<Texture2D>("boss"), new Vector2(290, 50), Color.White, 1000, 50000, new List<RectangleF>() { new RectangleF(0, 0, 322, 206), new RectangleF(109, 204, 102, 134) });

            enemyShipsTexture = Content.Load<Texture2D>("samplespaceships");
            for (float y = 0; y < enemyShipsTexture.Height; y += enemyShipsTexture.Height / 10f)
            {
                for (float x = 0; x < enemyShipsTexture.Width; x += enemyShipsTexture.Width / 10f)
                {
                    enemyShipsRectangles.Add(new Rectangle((int)x, (int)y, enemyShipsTexture.Width / 10, enemyShipsTexture.Height / 10));
                }
            }
            for (int i = 0; i < 10; i++)
            {
                ships.Add(new Enemy(enemyShipsTexture, new Vector2(RandomGenerator.randomGenerator.Next(0, GraphicsManager.ScreenWidth - 50), RandomGenerator.randomGenerator.Next(0, GraphicsManager.ScreenHeight / 2)), enemyShipsRectangles[RandomGenerator.randomGenerator.Next(0, enemyShipsRectangles.Count)], Color.White, 100, 10));
            }
            ships.Add(first);
        }


        protected override void UnloadContent()
        {

        }


        protected override void Update(GameTime gameTime)
        {
            InputManager.Update(gameTime);

            player.Position = new Vector2(InputManager.MouseState.X, InputManager.MouseState.Y);
            elaspedShootTime += gameTime.ElapsedGameTime;
            enemyElaspedShootTime += gameTime.ElapsedGameTime;
            //check if the mouse is clicked, then set isshoooting to true
            if (InputManager.KeyState.IsKeyDown(Keys.Space))
            {
                if (elaspedShootTime >= shootTime)
                {
                    elaspedShootTime = TimeSpan.FromMilliseconds(0);
                    //if time is divisible by 1
                    attacks.Add(new Attack(Content.Load<Texture2D>("lasar"), new Vector2(InputManager.MouseState.X + 26.6f, InputManager.MouseState.Y + 9), Color.Red, 10, 500, Team.Ally));
                    attacks.Add(new Attack(Content.Load<Texture2D>("lasar"), new Vector2(InputManager.MouseState.X + 68, InputManager.MouseState.Y + 9), Color.Red, 10, 500, Team.Ally));
                }
            }
            foreach (Ship enemy in ships)
            {
                if (enemyElaspedShootTime >= enemyShootTime)
                {
                    enemyElaspedShootTime = TimeSpan.FromMilliseconds(0);
                    attacks.Add(new Attack(Content.Load<Texture2D>("enemyAttack"), new Vector2(enemy.X + 10, enemy.Y), Color.White, 10, 100, Team.Enemy));
                }
            }
            elaspedAnimationTime += gameTime.ElapsedGameTime;
            if (elaspedAnimationTime >= animationTime)
            {
                currentShip++;
                if (currentShip >= enemyShipsRectangles.Count)
                {
                    currentShip = 0;
                }
                elaspedAnimationTime = new TimeSpan();
            }

            if (player.HealthStatus == HealthStatus.Dead)
            {
                player.Update(gameTime);
            }
            foreach (Ship enemy in ships)
            {

                if (enemy is Boss)
                {
                    //Debugger.Break();
                }
                enemy.Update(gameTime);
            }

            for (int i = 0; i < attacks.Count; i++)
            {
                attacks[i].Update(gameTime);
                if (attacks[i].Position.Y <= 0)
                {
                    attacks.RemoveAt(i);
                    i--;
                }
                else if (attacks[i].Team == Team.Ally)
                {
                    for (int ii = 0; ii < ships.Count; ii++)
                    {
                        if (ships[ii] is Boss)
                        {
                            bool hit = false;
                            for (int iii = 0; iii < ((Boss)ships[ii]).HitBoxes.Length; iii++)
                            {
                                if (attacks[i].Hitbox.Intersects(((Boss)ships[ii]).HitBoxes[iii].ToRectangle()))
                                {
                                    ships[ii].Health -= attacks[i].Damage;
                                    attacks.RemoveAt(i);
                                    i--;
                                    if (ships[ii].HealthStatus == HealthStatus.Dead)
                                    {
                                        ships.RemoveAt(ii);
                                        ii--;
                                    }
                                    hit = true;
                                    break;
                                }
                            }
                            if (hit)
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (attacks[i].Hitbox.Intersects(ships[ii].Hitbox))
                            {
                                ships[ii].Health -= attacks[i].Damage;
                                attacks.RemoveAt(i);
                                i--;
                                if (ships[ii].HealthStatus == HealthStatus.Dead)
                                {
                                    ships.RemoveAt(ii);
                                    ii--;
                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (attacks[i].Hitbox.Intersects(player.Hitbox))
                    {
                        player.Health -= attacks[i].Damage;
                        attacks.RemoveAt(i);
                        i--;
                    }
                }
            }




            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Navy);
            spriteBatch.Begin();
            player.Draw(spriteBatch);
            foreach (Attack l in attacks)
            {
                l.Draw(spriteBatch);
            }

            for (int i = 0; i < ships.Count; i++)
            {
                ships[i].Draw(spriteBatch);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
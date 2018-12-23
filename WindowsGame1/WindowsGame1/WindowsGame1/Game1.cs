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

namespace WindowsGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteText story;
        SpriteText option1;
        SpriteText option2;
        SpriteText option3;
        MouseState lastMS;
        bool isDead = false;
        int levelcount = 1;
        //string text = "Welcome to your death.\nHere, you will die. \nYou find yourself in a dark room. \nThere are 3 items. Pick your poison.";
        //string text1 = "Portal Gun";
        //string text2 = "Dynamite";
        //string text3 = "Mysterious Jar";
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
            story = new SpriteText();
            story.Load(Content.Load<SpriteFont>("SpriteFont"), "Welcome to your death.\nHere, you will die. \nYou find yourself in a dark room. \nThere are 3 items. Pick your poison.", new Vector2(50, 50), Color.Red);
            option1 = new SpriteText();
            option1.Load(Content.Load<SpriteFont>("SpriteFont"), "Portal Gun", new Vector2(100, 260), Color.DarkGreen);
            option2 = new SpriteText();
            option2.Load(Content.Load<SpriteFont>("SpriteFont"), "Dynamite", new Vector2(300, 260), Color.DarkGreen);
            option3 = new SpriteText();
            option3.Load(Content.Load<SpriteFont>("SpriteFont"), "Mysterious Jar", new Vector2(500, 260), Color.DarkGreen);

            // TODO: use this.Content to load your game content here
        }

        
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        void Dead(string message)
        {
            levelcount = -1;
            story._text = message;
            option1._text = "";
            option2._text = "Try Again";
            option3._text = "";
        }
        
        protected override void Update(GameTime gameTime)
        {

            MouseState ms = Mouse.GetState();
            if ((option2.rekt.Contains(ms.X, ms.Y)) && ms.LeftButton == ButtonState.Pressed && levelcount == -1 && lastMS.LeftButton == ButtonState.Released)
            {
                //set the text to the first options and levelcount = 1
                this.Initialize();
                levelcount = 1;
            }
            else if (option1.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 1 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You point it at the wall and shoot it, \nbut you realize you can't shoot\noutside of the room.\nRealizing this, you put it down. \nPick another item.";
            }
            else if (option2.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 1 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You pick it up. Light it?";
                option1._text = "Yes";
                option2._text = "No";
                option3._text = "";
                levelcount++;
            }
            else if (option2.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 2 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You put it down. What do you do?";
                option1._text = "Portal Gun";
                option2._text = "Dynamite";
                option3._text = "Mysterious Jar";
                levelcount = 1;
            }
            else if (option3.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 1 && lastMS.LeftButton == ButtonState.Released)
            {
                Dead("THERE IS A SNAKE. IT KILLS YOU. YOU DIE.");
            }
            
            else if (option1.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 2 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You light it, and put it in the corner. \nIt explodes, and you are left unharmed. \nIt is revealed you are in an even bigger room. \nYou find a scanner.";
                option1._text = "Portal Gun";
                option2._text = "Scanner";
                levelcount++;
            }
            else if (option1.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 3 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You can't do anything with this right now. \nYou put it down. Pick something else.";
                option1._text = "Portal Gun";
                option2._text = "Scanner";
            }
            else if (option2.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 3 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You find tiny holes in the room. \nYou hear a rumbling sound that \nmay or may not be an explosion.";
                option1._text = "Portal Gun";
                option2._text = "Scanner";
                option3._text = "Wait";
                levelcount++;
            }
            else if (option1.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 4 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "What will you do with it?";
                option1._text = "Shoot it \ninto a hole";
                option2._text = "Shoot it on\nthe celing \nand ground";
                option3._text = "Wait";
                levelcount++;
            }
            else if (option3.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 4 && lastMS.LeftButton == ButtonState.Released)
            {
                Dead("You wait and starve to death.");

            }

            else if (option2.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 5 && lastMS.LeftButton == ButtonState.Released)
            {
                Dead("You jump in, and you loop \ninfinitely and eventually die.");
            }
            else if (option3.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 5 && lastMS.LeftButton == ButtonState.Released)
            {
                Dead("You wait and blow up.");
            }
            
            else if (option1.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 5 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You make a portal outside the room.\nYou get out of the room,\nand the previous room explodes.\nYou find yourself in a bigger room.\nYou find food and a locked door.";
                option1._text = "Take food";
                option2._text = "Portal Gun";
                option3._text = "Look at door";
                levelcount++;
            }
            else if (option1.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 6 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "What will you do with the food?";
                option1._text = "Eat it";
                option2._text = "Make a key";
                option3._text = "Both";
                levelcount++;
            }
            else if (option2.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 6 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You find the portal gun is broken now. \nWhat will you do now?";
                option1._text = "Take food";
                option2._text = "Portal Gun";
                option3._text = "Look at door";
            }
            else if (option3.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 6 && lastMS.LeftButton == ButtonState.Released)
            {
                Dead("You find it is a thin \nwooden door. You try \nto punch it open, but\nyou're too weak. \nYou're too tired and die of exhaustion.");
                
            }
            else if (option1.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 7 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You immediately feel better. \nWhat will you do?";
                option1._text = "Portal Gun";
                option2._text = "Wait";
                option3._text = "Look at door";
                levelcount++;
            }
            else if (option2.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 7 && lastMS.LeftButton == ButtonState.Released)
            {
                Dead("You make a key out of the food.\nYou use it to walk to the door,\nbut you are too tired to walk there.\nYou fall and starve to death.");
            }
            else if (option3.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 7 && lastMS.LeftButton == ButtonState.Released)
            {
                Dead("You eat until you are full\nand find you don't have any food left.\nYou have nothing to do\nand starve to death.");
            }
            else if (option1.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 8 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "The portal gun is broken now. \nWhat will you do now?";
                option1._text = "Portal Gun";
                option2._text = "Wait";
                option3._text = "Look at door";
            }
            else if (option2.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 8 && lastMS.LeftButton == ButtonState.Released)
            {
                Dead("You wait and starve to death.");
            }
            else if (option3.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 8 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You look at the door and\nyou realize you can punch it open. Do it?";
                option1._text = "Yes";
                option2._text = "No";
                option3._text = "";
                levelcount++;
            }
            else if (option1.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 9 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "You break the door. You enter another room\nthat looks exactly like the original room.\nYou realize it is the original room.\nYou forget your memories...";
                option1._text = "";
                option2._text = "Continue";
                option3._text = "";
                levelcount++;
            }
            else if (option2.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 9 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "The no button is broken. \nSorry.";
                option1._text = "Yes";
                option2._text = "No";
                option3._text = "";
            }
            else if (option2.rekt.Contains(ms.X, ms.Y) && ms.LeftButton == ButtonState.Pressed && levelcount == 10 && lastMS.LeftButton == ButtonState.Released)
            {
                story._text = "Welcome to your death.\nHere, you will die. \nYou find yourself in a dark room. \nThere are 3 items. Pick your poison.";
                option1._text = "Portal Gun";
                option2._text = "Dynamite";
                option3._text = "Mysterious Jar";
                levelcount = 1;
            }
            // TODO: Add your update logic here
            lastMS = ms;
            base.Update(gameTime);
        }
        

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            story.Draw(spriteBatch);
            option1.Draw(spriteBatch);
            option2.Draw(spriteBatch);
            option3.Draw(spriteBatch);
            spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace WindowsGame3
{
    public static class InputManager
    {
        public static KeyboardState KeyState;
        public static KeyboardState LastKeyState;
        public static MouseState MouseState;
        public static MouseState LastMouseState;

        public static void Update(GameTime gameTime)
        {
            LastKeyState = KeyState;
            KeyState = Keyboard.GetState();
            LastMouseState = MouseState;
            MouseState = Mouse.GetState();
        }
    }
}

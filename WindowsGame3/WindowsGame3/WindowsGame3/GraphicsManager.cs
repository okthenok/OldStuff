using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WindowsGame3
{
    public static class GraphicsManager
    {
        static GraphicsDeviceManager _graphics;

        public static int ScreenWidth
        {
            get
            {
                return _graphics.GraphicsDevice.Viewport.Width;
            }
            set
            {
                _graphics.PreferredBackBufferWidth = value;
                _graphics.ApplyChanges();
            }
        }

        public static int ScreenHeight
        {
            get
            {
                return _graphics.GraphicsDevice.Viewport.Height;
            }
            set
            {
                _graphics.PreferredBackBufferHeight = value;
                _graphics.ApplyChanges();
            }
        }

        public static void Initialize(GraphicsDeviceManager graphics)
        {
            _graphics = graphics;
        }
    }
}

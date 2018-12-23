using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SwagCapitalistv2._0
{
    public class SwagProducer : Button
    {
        private Producers producers;

        public Producers Producers
        {
            get { return producers; }
            set { producers = value; }
        }

        int typeOfSwag;

        
        public SwagProducer(Texture2D image, Vector2 position, Color color, int typeOfSwag, Producers producer)
            :base(image, position, color)
        {
            producers = producer;
            this.typeOfSwag = typeOfSwag;
        }

        public SwagProducer(Texture2D image, Vector2 position, Color color, Rectangle sourceRectangle) //int typeOfSwag, Producers producer, 
            : base(image, position, sourceRectangle, color)
        {

        }
        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            base.Update(gameTime);
        }
    
    }
}

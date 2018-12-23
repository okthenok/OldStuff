using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SwagCapitalistv2._0
{
    public class Manager
    {
        SpriteFont _font;
        SpriteBatch _spriteBatch;
        PlayerStats _playerStats;
        List<SwagProducer> swagProducers = new List<SwagProducer>();

        //TODO: CREATE A LIST OF SWAGPRODUCERS, USE AN ENUM TO DIFFERENTIATE BETWEEN EACH ONE, AND CREATE THE UPDATE TO CHECK WHETHER THEY ARE CLICKED AND ARE PRODUCING SWAG 

        public Manager(SpriteBatch spriteBatch)
        {
            _spriteBatch = spriteBatch;
            _playerStats = new PlayerStats();
        }

        public void LoadContent(SpriteFont spriteFont, PlayerStats playerStats)
        {
            _font = spriteFont;
            _playerStats = playerStats;
            
        }

        public void Update()
        {
            foreach (SwagProducer swagProducer in swagProducers)
            {
                if (swagProducer.Clicked)
                {
                    if (swagProducer.Producers == Producers.abe)
                    {
                        _playerStats.Abe += 1;
                        //add the score or whatever and add 1 to the abe producer so u get automatic producing ur shaking DOES NOT FAZE ME
                    }
                    
                }
            }
        }

        public void Draw()
        {
            
            _spriteBatch.DrawString(_font, _playerStats.Kappa.ToString(), new Vector2(730, 75), Color.Black);
        }

    }
}

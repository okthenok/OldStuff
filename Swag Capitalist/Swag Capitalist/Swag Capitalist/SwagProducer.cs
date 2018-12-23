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
    public class SwagProducer : Button
    {
        bool activated = false;
        int numberOfProducers = 0;
        int swagPerSecond = 0;
        //initialize these in your constructors
        //if they need to be edited at all in game1 or any other class, you need to make a get or a set or both depending on what you need
        double sunglassesCost = 100;
        double hkKeychainsCost = 350;
        double fgBeardCost = 1000;
        double sparklesCost = 2500;
        double haloCost = 6000;
        double goldSuitCost = 12000;
        double abeCost = 99999;
        double multiplierPerBuy = 1.15;

        Currency kappa;
        Currency smorc;
        Currency babyrage;
        Currency biblethump;


        public SwagProducer(Texture2D texture, Vector2 position, Color color, double sunglassesCost = 100, double hkKeychainsCost = 350, double fgBeardCost = 1000, double sparkesCost = 2500, double haloCost = 6000, double goldSuitCost = 15000, double abeCost = 99999)
            : base(texture, position, color)
        {
            
        }
        public SwagProducer(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, double sunglassesCost = 100, double hkKeychainsCost = 350, double fgBeardCost = 1000, double sparkesCost = 2500, double haloCost = 6000, double goldSuitCost = 15000, double abeCost = 99999)
            : base(texture, position, sourceRectangle, color)
        {
            
        }
        #region swagProducerGetSet
        public double SunglassesCost
        {
            get
            {
                return sunglassesCost;
            }
            set
            {
                sunglassesCost = value;
            }
        }
        public double HkKeychainsCost
        {
            get
            {
                return hkKeychainsCost;
            }
            set
            {
                hkKeychainsCost = value;
            }
        }
        public double FgBeardCost
        {
            get
            {
                return fgBeardCost;
            }
            set
            {
                fgBeardCost = value;
            }
        }
        public double SparklesCost
        {
            get
            {
                return sparklesCost;
            }
            set
            {
                sparklesCost = value;
            }
        }
        public double HaloCost
        {
            get
            {
                return haloCost;
            }
            set
            {
                haloCost = value;
            }
        }
        public double GoldSuitCost
        {
            get
            {
                return goldSuitCost;
            }
            set
            {
                goldSuitCost = value;
            }
        }
        public double AbeCost
        {
            get
            {
                return abeCost;
            }
            set
            {
                abeCost = value;
            }
        }
        #endregion

        public void LoadContent()
        {
        
        }

        public bool Activated
        {
            get
            {
                return activated;
            }
            set
            {
                activated = value;
            }
        }

        public int NumberOfProducers
        {
            get
            {
                return numberOfProducers;
            }
            set
            {
                numberOfProducers = value;
            }
        }

        public int SwagPerSecond
        {
            get
            {
                return swagPerSecond;
            }
            set
            {
                swagPerSecond = value;
            }
        }

        public override void Update(GameTime gameTime)
        {
            if (Clicked && Money >= Cost)
            {
                if (Activated == false)
                {
                    Money -= (int)Cost;
                    Activated = true;
                    NumberOfProducers += 1;
                }
                else if (Activated && kappa.Money >= Cost * multiplierPerBuy)
                {
                    Cost *= multiplierPerBuy;
                    Money -= (int)Cost;
                    NumberOfProducers += 1;
                    SwagPerSecond = 2;
                    SwagPerSecond *= NumberOfProducers;
                }
            }
            if (Activated)
            {
                if (oneSecond < counter)
                {
                    kappa.Money += SwagPerSecond;
                    counter = new TimeSpan();
                }
            }
            base.Update(gameTime);
        }

        //swagbox (clickable)

        //SwagProducer
        //hello kitty keychains
        //full-grown beard
        //sparkles
        //immortality
        //snapback
        //gold suit
        //abe

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwagCapitalistv2._0
{
    public class PlayerStats
    {
        #region ints
        int swag;

        int kappa;
        int smorc;
        int babyrage;
        int biblethump;
        int residentsleeper;
        int failfish;
        int pogchamp;
        int swagAbe;

        int pureSwag;

        int sunglasses;
        int hkKeychains;
        int fgBeard;
        int sparkles;
        int immortality;
        int snapback;
        int goldSuit;
        int abe;
        #endregion
        
        #region getSets

        public int Swag
        {
            get { return swag; }
            set { swag = value; }
        }


        public int Kappa
        {
            get { return kappa; }
            set { kappa = value; }
        }
        public int Smorc
        {
            get { return smorc; }
            set { smorc = value; }
        }
        public int Babyrage
        {
            get { return babyrage; }
            set { babyrage = value; }
        }
        public int Biblethump
        {
            get { return biblethump; }
            set { biblethump = value; }
        }
        public int Residentsleeper
        {
            get { return residentsleeper; }
            set { residentsleeper = value; }
        }
        public int Failfish
        {
            get { return failfish; }
            set { failfish = value; }
        }
        public int Pogchamp
        {
            get { return pogchamp; }
            set { pogchamp = value; }
        }
        public int SwagAbe
        {
            get { return swagAbe; }
            set { swagAbe = value; }
        }

        public int Sunglasses
        {
            get { return sunglasses; }
            set { sunglasses = value; }
        }
        public int HkKeychains
        {
            get { return hkKeychains; }
            set { hkKeychains = value; }
        }
        public int FgBeard
        {
            get { return fgBeard; }
            set { fgBeard = value; }
        }
        public int Sparkles
        {
            get { return sparkles; }
            set { sparkles = value; }
        }
        public int Immortality
        {
            get { return immortality; }
            set { immortality = value; }
        }
        public int SnapBack
        {
            get { return snapback; }
            set { snapback = value; }
        }
        public int GoldSuit
        {
            get { return goldSuit; }
            set { goldSuit = value; }
        }
        public int Abe
        {
            get { return abe; }
            set { abe = value; }
        }
#endregion

        #region values
        public int SunValue = 5; //Kappas
        public int HKKValue = 50; //Kappas
        public int FGBValue = 6; //SMOrcs
        public int SpkValue = 60; //SMOrcs
        public int ImtValue = 7; //BabyRages
        public int SnbValue = 70; //BabyRages
        public int GdsValue = 8; //BibleThumps
        public int AbeValue = 80; //BibleThumps
        #endregion

        public PlayerStats()
        {
           
        }
        

    }
}

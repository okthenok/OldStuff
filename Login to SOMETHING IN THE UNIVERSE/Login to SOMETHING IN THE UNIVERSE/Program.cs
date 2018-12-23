using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            string [] Usernames = new string [6];
            string [] Passwords = new string[6];
            Usernames[0] = "Teemo";
            Passwords[0] = "CaptainTeemoOnDuty";
            Usernames[1] = "Nidalee";
            Passwords[1] = "TheyWillFearTheWild";
            Usernames[2] = "Annie";
            Passwords[2] = "YouWannaPlayToo";
            Usernames[3] = "Kogmaw";
            Passwords[3] = "SoHungry...";
            Usernames[4] = "Vayne";
            Passwords[4] = "LetUsHuntThoseWhoHaveFallenToDarkness";
            Usernames[5] = "Jax";
            Passwords[5] = "Let'sDoThis";
            //string CorrectUsername = "Teemo";
            //string CorrectPassword = "CaptainTeemoOnDuty";
            //string CorrectUsername2 = "Nidalee";
            //string CorrectPassword2 = "TheyWillFearTheWild";
            //string CorrectUsername3 = "Annie";
            //string CorrectPassword3 = "YouWannaPlayToo";
            //string CorrectUsername4 = "Kogmaw";
            //string CorrectPassword4 = "SoHungry...";
            //string CorrectUsername5 = "Vayne";
            //string CorrectPassword5 = "LetUsHuntThoseWhoHaveFallenToDarkness";
            //string CorrectUsername6 = "Jax";
            //string CorrectPassword6 = "Let'sDoThis";
            string EnteredUsername;
            string EnteredPassword;
            Console.WriteLine("Welcome to SOMETHING IN THE UNIVERSE!!!");
            Console.WriteLine();
            Console.WriteLine("Please type your username");
            EnteredUsername = Console.ReadLine();
            Console.WriteLine("Please type in your password");
            EnteredPassword = Console.ReadLine();
            for (int i = 0; i < Usernames.Length; i++)
            {
                if (EnteredUsername == Usernames[i] && EnteredPassword == Passwords[i])
                {
                    Console.WriteLine("You have logged in");
                    Console.WriteLine("YAY!");
                    Console.WriteLine("(>**)> <(**<)");
                    break;
                }
            }
            ////if (Usernames[0] == EnteredUsername && Passwords[0] == EnteredPassword || Usernames[1] == EnteredUsername && Passwords[1] == EnteredPassword || Usernames[2] == EnteredUsername && Passwords[2] == EnteredPassword || Usernames[3] == EnteredUsername && Passwords[3] == EnteredPassword || Usernames[4] == EnteredUsername && Passwords[4] == EnteredPassword || Usernames[5] == EnteredUsername && Passwords[5] == EnteredPassword)
            //{

            //    Console.WriteLine("You have logged in");
            //    Console.WriteLine("You have helped give $100 to LOL. Thank you for your support");
            //}
            //else
            //{
            //    Console.WriteLine("You didn't log in");
            //    Console.WriteLine("Please try again");
            //    Console.WriteLine("Please help support LOL by logging in. Every time you log in, LOL gets $100");
            //}

            



            Console.ReadKey();
        }
    }
}


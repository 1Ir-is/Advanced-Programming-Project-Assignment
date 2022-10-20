using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment___Advanced_Programming
{
    public class UserInterface
    {
        public static void Header()
        {
            WriteLine("=============== Music Disc Shop ===============");
            WriteLine("===============================================");
        }

        public static int menuOption()
        {
            WriteLine("||   1. Add Music Disc.                    ");
            WriteLine("||   2. Show Information Of All Disc.");
            WriteLine("||   3. Show EDM Music Disc.");
            WriteLine("||   4. Show POP Music Disc.");
            WriteLine("||   5. Show Music Disc By Id.");
            WriteLine("||   6. Show Music Disc By Name.");
            WriteLine("||   7. Remove Disc By Id.");
            WriteLine("||   8. Update Disc By Id.");
            WriteLine("||   0. Exit.");
            Write(" Enter your option: ");
            return int.Parse(ReadLine());
        }

        public static string addDisc()
        {
            WriteLine("|| What kind of disc do you want to import? ||");
            WriteLine("||   Press EDM to import EDM Music Disc.    ||");
            WriteLine("||   Press POP to import POP Music Disc.    ||");
            WriteLine("||   Press E to Exit.                       ||");
            Write(" Enter your option: ");
            return ReadLine();
        }

        public static int enterID()
        {
            Write(" Enter ID: ");
            int id = int.Parse(ReadLine());
            return id;
        }

        public static string enterName()
        {
            Write(" Enter Disc's Name: ");
            string name = ReadLine();
            return name;
        }

        public static string enterArtist()
        {
            Write(" Enter Disc's Artist: ");
            string artist = ReadLine();
            return artist;
        }

        public static string enterDescription()
        {
            Write(" Enter Disc's Description: ");
            string description = ReadLine();
            return description;
        }

        public static int enterYear()
        {
            Write(" Enter Disc's Year: ");
            int year = int.Parse(ReadLine());
            return year;
        }

        public static decimal enterPrice()
        {
            Write(" Enter Disc's Price: ");
            decimal price = decimal.Parse(ReadLine());
            return price;
        }

        public static string messageChoice(bool result)
        {
            if (!result)
            {
                return "Error, please try again!";
            }
            return "Success";
        }
    }
}

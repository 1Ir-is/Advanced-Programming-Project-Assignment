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

        // MAIN HEADER
        public static void Header()
        {
            WriteLine(" =============== Music Disc Shop ===============");
            WriteLine(" ===============================================");
        }
        // END


        // SUB HEADER
        public static void subHeader()
        {
            WriteLine(" =============== Add Music Disc ===============");
            WriteLine(" ==============================================");
        }
        // END


        // MENU OPTION
        public static int menuOption()
        {
            WriteLine(" ||   1. Add Music Disc.                      ||");
            WriteLine(" ||   2. Show Information Of All Disc.        ||");
            WriteLine(" ||   3. Show EDM Music Disc.                 ||");
            WriteLine(" ||   4. Show POP Music Disc.                 ||");
            WriteLine(" ||   5. Show Music Disc By Id.               ||");
            WriteLine(" ||   6. Show Music Disc By Name.             ||");
            WriteLine(" ||   7. Show Music Disc By Name Of Artist.   ||");
            WriteLine(" ||   8. Remove Disc By Id.                   ||");
            WriteLine(" ||   9. Update Disc By Id.                   ||");
            WriteLine(" ||   0. Exit.                                ||");
            Write(" Enter your option: ");
            return int.Parse(ReadLine());
        }
        // END


        // MENU FOR ADD DISC
        public static string addDisc()
        {
            WriteLine(" || What kind of disc do you want to import? ||");
            WriteLine(" ||   Press EDM to import EDM Music Disc.    ||");
            WriteLine(" ||   Press POP to import POP Music Disc.    ||");
            WriteLine(" ||   Press E to Exit.                       ||");
            Write(" Enter your option: ");
            return ReadLine();
        }
        // END


        // INPUT ID
        public static int enterID()
        {
            Write(" Enter ID: ");
            int id = int.Parse(ReadLine());
            return id;
        }
        // END


        // INPUT 
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
        // END


        // INPUT UPDATE
        public static string EnterUpdateName()
        {
            Write(" Enter New Disc's Name: ");
            string up_name = ReadLine();
            return up_name;
        }
        public static string EnterUpdateArtist()
        {
            Write(" Enter New Disc's Artist: ");
            string up_artist = ReadLine();
            return up_artist;
        }
        public static int EnterUpdateYear()
        {
            Write(" Enter New Disc's Year: ");
            int up_year = int.Parse(ReadLine());
            return up_year;
        }
        public static decimal EnterUpdatePrice()
        {
            Write(" Enter New Disc's Price: ");
            decimal up_price = decimal.Parse(ReadLine());
            return up_price;
        }
        // END


        // MESSAGE 
        public static string messageRemove(bool result)
        {
            if (!result)
            {
                return " Remove failed, please try again!";
            }
            return " Remove Succeeded";
        }

        public static string messageUpdate(bool result)
        {
            if (!result)
            {
                return " Update failed, please try again!";
            }
            return " Update Succeeded";
        }
        // END
    }
}

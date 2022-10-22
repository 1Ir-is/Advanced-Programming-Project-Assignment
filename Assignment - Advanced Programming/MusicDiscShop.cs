using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Console;

namespace Assignment___Advanced_Programming
{
    public class MusicDiscShop
    {
        private List<MusicDisc> musicDiscs = new List<MusicDisc>();

        MusicDisc musicDisc1 = new EdmMusicDisc();

        public MusicDiscShop() { }

        // CHECK ID
        public bool checkID(int id)
        {
            MusicDisc discList = musicDiscs.FirstOrDefault(i => i.Id.Equals(id));
            if (discList != null)
            {
                return true;
            }
            return false;
        }
        // End


        // ADD MUSIC DISC
        public void AddMusicDisc(MusicDisc musicDisc)
        {
            try
            {
                if (checkID(musicDisc.Id))
                {
                    throw new ArgumentException(" Id is duplicated, Please enter again!");
                }
                else
                {
                    musicDiscs.Add(musicDisc);
                }
            }
            catch (ArgumentException e)
            {
                WriteLine(e.Message);
            }
        }
        // END


        // DISPLAY MUSIC INFORMATION
        public string PrintAllDisc()
        {
            var result = new StringBuilder();
            foreach (var md in musicDiscs)
            {
                result.AppendLine(md.DisplayMusicInfo());
            }
            return result.ToString();
        }
        // END

        // DISPLAY ALL EDM INFO
        public void PrintAllEdm()
        {
            foreach (var edmMusic in musicDiscs)
            {
                edmMusic.DisplayMusicInfo().GetType().Equals("EDM MUSIC");
            }
        }


        // UPDATE BY ID
        public bool UpdateById(int id)
        {
            try
            {
                MusicDisc md = musicDiscs.FirstOrDefault(i => i.Id.Equals(id));
                if (md != null)
                {
                    Write(" Enter new name: ");
                    string name = ReadLine();
                    Write(" Enter new name of artist: ");
                    string artist = ReadLine();
                    Write(" Enter new year: ");
                    int year = int.Parse(ReadLine());
                    Write(" Enter new price: ");
                    decimal price = decimal.Parse(ReadLine());
                    md.Name = name;
                    md.Artist = artist;
                    md.Year = year;
                    md.Price = price;
                }
                else
                {
                    WriteLine(" Id is invalid, please enter again!");
                }
            }
            catch (ArgumentException e)
            {
                WriteLine(e.Message);
            }
            return false;
        }
        // END   


        // DELETE BY ID
        public bool DeleteById(int id)
        {
            MusicDisc md = musicDiscs.FirstOrDefault(i => i.Id.Equals(id));
            if (md != null)
            {
                musicDiscs.Remove(md);
                return true;
            }
            return false;
        }
        // END


        // FIND DISC BY ID
        public string GetMusicDiscById(int id)
        {
            MusicDisc md = musicDiscs.FirstOrDefault(i => i.Id.Equals(id));
            if (md != null)
            {
                return md.DisplayMusicInfo();

            }
                return " Id does not exist, please enter again!";
        }
        // END


        // FIND DISC BY NAME
        public string GetMusicDiscsByName(string name)
        {
            var result = new StringBuilder();
            foreach (var md in musicDiscs.Where(n => n.Name.Equals(name)))
            {
                result.AppendLine(md.DisplayMusicInfo());
            }
            return result.ToString();
        }
        // END

        
        // FIND DISC BY NAME OF ARTIST
        public string GetMusicDiscByArtist(string artist)
        {
            var result = new StringBuilder();
            foreach (var md in musicDiscs.Where(a => a.Artist.Equals(artist)))
            {
                result.AppendLine(md.DisplayMusicInfo());
            }
            return result.ToString();
        }
        // END
    }
}

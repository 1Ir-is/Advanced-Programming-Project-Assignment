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

        public MusicDiscShop() { }

        public bool checkID(int id)
        {
            MusicDisc discList = musicDiscs.FirstOrDefault(i => i.Id.Equals(id));
            if (discList != null)
            {
                return true;
            }
            return false;
        }

        public void AddMusicDisc(MusicDisc musicDisc)
        {
            try
            {
                if (checkID(musicDisc.Id))
                {
                    throw new ArgumentException("Duplicate Id, Please enter again!");
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

        public MusicDisc FindDiscById(int id)
        {
            MusicDisc searchResult = null;
            if (musicDiscs != null && musicDiscs.Count > 0)
            {
                foreach (MusicDisc md in musicDiscs)
                {
                    if (md.Id == id)
                    {
                        searchResult = md;
                    }
                }
            }
            return searchResult;
        }

        public List<MusicDisc> GetMusicDiscsByName(string name)
        {
            var result = new List<MusicDisc>();
            result = musicDiscs.Where(i => i.Name.Equals(name)).ToList();
            return result;
        }

        public bool DeleteById(int id)
        {
            bool isDelete = false;
            MusicDisc md = FindDiscById(id);
            if (md != null)
            {
                isDelete = musicDiscs.Remove(md);
            }
            return isDelete;
        }

        public void UpdateById(int id)
        {
            try
            {
                MusicDisc md = musicDiscs.FirstOrDefault(i => i.Id.Equals(id));
                if (md != null)
                {
                    WriteLine("Enter new name: ");
                    string name = ReadLine();
                    WriteLine("Enter new name of artist: ");
                    string artist = ReadLine();
                    WriteLine("Enter new year: ");
                    int year = int.Parse(ReadLine());
                    WriteLine("Enter new price: ");
                    decimal price = decimal.Parse(ReadLine());
                    md.Name = name;
                    md.Artist = artist;
                    md.Year = year;
                    md.Price = price;
                }
                else
                {
                    WriteLine("Enter a valid Id!");
                }
            }
            catch (ArgumentException e)
            {
                WriteLine(e.Message);
            }
        }
    }
}

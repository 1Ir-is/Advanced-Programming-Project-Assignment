using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___Advanced_Programming
{
    public abstract class MusicDisc
    {
        private int id;
        private string name;
        private string artist;
        private string description;
        private int year;
        private decimal price;

        public MusicDisc()
        {
                
        }
        public MusicDisc(int id, string name, string artist, string description, int year, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Artist = artist;
            this.Description = description;
            this.Year = year;
            this.Price = price;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name of the song is not valid!");
                }

                this.name = value;
            }
        }

        public string Artist
        {
            get => artist;
            set
            {
                var indexOf = value.IndexOf(' ');
                if (char.IsDigit(value[indexOf + 1]))
                {
                    throw new ArgumentException("Artist is not valid!");
                }

                this.artist = value;
            }
        }

        public string Description
        {
            get => description;
            set
            {
                this.description = value;
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Year is not valid!");
                }

                this.year = value;
            }
        }

        public virtual decimal Price
        {
            get => price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price is not valid!");
                }

                this.price = value;
            }
        }


        public abstract string GetType();
        public abstract string DisplayMusicInfo();
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___Advanced_Programming
{
    public class EdmMusicDisc : MusicDisc
    {
        public EdmMusicDisc()
        {

        }
        public EdmMusicDisc(int id, string name, string artist, string category, int year, decimal price)
            : base(id, name, artist, category, year, price)
        {

        }

        public override decimal Price
        {
            get
            {
                return base.Price * 1.3m;
            }
        }

        public override string DisplayMusicInfo()
        {
            var sb = new StringBuilder();
            sb.Append("Id: ").AppendLine($"{this.Id}")
              .Append("Type: ").AppendLine(this.GetType())
              .Append("Name: ").AppendLine(this.Name)
              .Append("Artist: ").AppendLine(this.Artist)
              .Append("Description: ").AppendLine(this.Description)
              .Append("Year: ").AppendLine($"{this.Year}")
              .Append("Price: ").Append($"{this.Price:f1}");

            return sb.ToString();           
        }

        public override string GetType()
        {
            return "EDM MUSIC";
        }
    }
}

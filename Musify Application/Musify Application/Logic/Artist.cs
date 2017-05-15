using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musify_Application
{
    public class Artist
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Biography { get; private set; }
        public string BigImage { get; private set; }
        public string SmallImage { get; private set; }
        public List<Genre> ArtistGenres { get; private set; }

        public Artist(int _id)
        {
            Id = _id;
        }

        public Artist()
        {
            this.ArtistGenres = new List<Genre>();
        }

        public Artist(string name, string biography, string bigImage, string smallImage)
        {
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;

        }

        public Artist(int id, string name, string biography, string bigImage, string smallImage)
        {
            Id = id;
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;
        }

        public Artist(string name, string biography, string bigImage, string smallImage, List<Genre> artistGenres)
        {
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;
            ArtistGenres = artistGenres;

        }

        public Artist(int id, string name, string biography, string bigImage, string smallImage, List<Genre> artistGenres)
        {
            Id = id;
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;
            ArtistGenres = artistGenres;
        }

        public override string ToString()
        {
                return Id + "   " + Name + "   " +Biography + "   " + BigImage;
        }
    }
}

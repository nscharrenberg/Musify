using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Genre
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public List<Artist> Artists { get; private set; }

        public Genre(string name, string description, string image)
        {
            Name = name;
            Description = description;
            Image = image;
        }

        public Genre(int id, string name, string description, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
        }
        public Genre(string name, string description, string image, List<Artist> artists)
        {
            Name = name;
            Description = description;
            Image = image;
            Artists = artists;
        }

        public Genre(int id, string name, string description, string image, List<Artist> artists)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Artists = artists;
        }

        public override string ToString()
        {
            return Id + "   " + Name + "   " + Description + "   " + Image;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musify_Application
{
    public class Genre
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }

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

        public override string ToString()
        {
                return Id + "   " + Name + "   " + Description + "   " + Image;
        }
    }
}

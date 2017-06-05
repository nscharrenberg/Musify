using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public bool Public { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // List
        public List<Song> Songs { get; set; }
    }
}
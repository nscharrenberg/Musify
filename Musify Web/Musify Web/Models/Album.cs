using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Album
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string ImageBigUrl { get; private set; }
        public string ImageSmallUrl { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public Artist Artist { get; set; }
        public List<Song> Songs { get; set; }
    }
}
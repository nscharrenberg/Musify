using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Artist
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string ImageBigUrl { get; private set; }
        public string ImageSmallUrl { get; private set; }
        public string Biography { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        // List
        public List<Genre> Genres { get; set; }
        public List<Album> Albums { get; set; }
    }
}
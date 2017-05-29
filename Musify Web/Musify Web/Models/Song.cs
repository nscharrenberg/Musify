using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Song
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Number { get; private set; }
        public int Dutarion { get; private set; }
        public string YoutubeUrl { get; private set; }
        public string SoundcloudUrl { get; private set; }
        public string ServerUrl { get; private set; }
        public Album Album { get; private set; }
        
        // List
        public List<Artist> Artists { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int Duration { get; set; }
        public string YoutubeUrl { get; set; }
        public string SoundcloudUrl { get; set; }
        public string ServerUrl { get; set; }
        public Album Album { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        
        // List
        public List<Artist> Artists { get; set; }

        public Song(int id, string name, int number, int duration, string youtubeUrl, string soundcloudUrl, string serverUrl, Album album, DateTime created, DateTime updated, List<Artist> artists)
        {
            Id = id;
            Name = name;
            Number = number;
            Duration = duration;
            YoutubeUrl = youtubeUrl;
            SoundcloudUrl = soundcloudUrl;
            Album = album;
            ServerUrl = serverUrl;
            Created = created;
            Updated = updated;
            Artists = artists;
        }
    }
}
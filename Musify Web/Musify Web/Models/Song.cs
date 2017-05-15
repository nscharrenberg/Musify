using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Song
    {
        public int Id { get; private set; }
        public string Duration { get; private set; }
        public string SongUrl { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<Playlist> Playlists { get; private set; }

        public Song(string duration, string songUrl, DateTime createdAt)
        {
            Duration = duration;
            SongUrl = songUrl;
            CreatedAt = createdAt;
        }

        public Song(int id, string duration, string songUrl, DateTime createdAt)
        {
            Id = id;
            Duration = duration;
            SongUrl = songUrl;
            CreatedAt = createdAt;
        }

        public Song(string duration, string songUrl, DateTime createdAt, List<Playlist> playlists)
        {
            Duration = duration;
            SongUrl = songUrl;
            CreatedAt = createdAt;
            Playlists = playlists;
        }

        public Song(int id, string duration, string songUrl, DateTime createdAt, List<Playlist> playlists)
        {
            Id = id;
            Duration = duration;
            SongUrl = songUrl;
            CreatedAt = createdAt;
            Playlists = playlists;
        }
    }
}
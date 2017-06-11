using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Song
    {
        private List<Artist> artist;

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a Song name")]
        [Display(Name = "Song Name")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the position of this Song on the Album")]
        [Display(Name = "Song Position on Album")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Please provide the length of this Song")]
        [Display(Name = "Song Length")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Please provide a youtube link")]
        [Display(Name = "Song Youtube link")]
        public string YoutubeUrl { get; set; }

        [Required(ErrorMessage = "Please provide a soundcloud link")]
        [Display(Name = "Song Soundcloud link")]
        public string SoundcloudUrl { get; set; }

        [Required(ErrorMessage = "Please provide a server link")]
        [Display(Name = "Song Server link")]
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

        public Song(int id, string name, int number, int duration, string youtubeUrl, string soundcloudUrl, string serverUrl, Album album, DateTime created, DateTime updated)
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
        }

        public Song(int id, string name, int number, int duration, string youtubeUrl, string soundcloudUrl, string serverUrl, DateTime created, DateTime updated, List<Artist> artists)
        {
            Id = id;
            Name = name;
            Number = number;
            Duration = duration;
            YoutubeUrl = youtubeUrl;
            SoundcloudUrl = soundcloudUrl;
            ServerUrl = serverUrl;
            Created = created;
            Updated = updated;
            Artists = artists;
        }

        public Song(string name, int number, int duration, string youtubeUrl, string soundcloudUrl, string serverUrl, DateTime created, DateTime updated, List<Artist> artists)
        {
            Name = name;
            Number = number;
            Duration = duration;
            YoutubeUrl = youtubeUrl;
            SoundcloudUrl = soundcloudUrl;
            ServerUrl = serverUrl;
            Created = created;
            Updated = updated;
            Artists = artists;
        }

        public Song(string name, int number, int duration, string youtubeUrl, string soundcloudUrl, string serverUrl, Album album, DateTime created, DateTime updated, List<Artist> artists)
        {
            Name = name;
            Number = number;
            Duration = duration;
            YoutubeUrl = youtubeUrl;
            SoundcloudUrl = soundcloudUrl;
            ServerUrl = serverUrl;
            Album = album;
            Created = created;
            Updated = updated;
            Artists = artists;
        }

        public Song(string name, int number, int duration, string youtubeUrl, string soundcloudUrl, string serverUrl, DateTime created, DateTime updated)
        {
            Name = name;
            Number = number;
            Duration = duration;
            YoutubeUrl = youtubeUrl;
            SoundcloudUrl = soundcloudUrl;
            ServerUrl = serverUrl;
            Created = created;
            Updated = updated;
        }

        public Song(string name, int number, int duration, string youtubeUrl, string soundcloudUrl, string serverUrl, Album album, DateTime created, DateTime updated)
        {
            Name = name;
            Number = number;
            Duration = duration;
            YoutubeUrl = youtubeUrl;
            SoundcloudUrl = soundcloudUrl;
            ServerUrl = serverUrl;
            Album = album;
            Created = created;
            Updated = updated;
        }

        public Song(int id, string name, int duration)
        {
            this.Id = id;
            this.Name = name;
            this.Duration = duration;
        }

        public Song()
        {
            
        }
    }
}
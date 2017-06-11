using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Album
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter an Album name")]
        [Display(Name = "Album Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the release date of this Album")]
        [Display(Name = "Album releasedate")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please add an album cover")]
        [Display(Name = "Album image")]
        public string ImageBigUrl { get; set; }

        [Required(ErrorMessage = "Please enter a thumbnail of the album cover")]
        [Display(Name = "Album thumbnail")]
        public string ImageSmallUrl { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Artist Artist { get; set; }
        public List<Song> Songs { get; set; }



        public Album(int id, string name, DateTime releaseDate, string imageBigUrl, string imageSmallUrl, Artist artist , DateTime createdAt, DateTime updatedAt, List<Song> songs)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
            ImageBigUrl = imageBigUrl;
            ImageSmallUrl = imageSmallUrl;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Artist = artist;
            Songs = songs;
        }

        public Album(int id, string name, DateTime releaseDate, string imageBigUrl, string imageSmallUrl, Artist artist, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
            ImageBigUrl = imageBigUrl;
            ImageSmallUrl = imageSmallUrl;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Artist = artist;
        }

        public Album(int id, string name, DateTime releaseDate, string imageBigUrl, string imageSmallUrl, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
            ImageBigUrl = imageBigUrl;
            ImageSmallUrl = imageSmallUrl;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public Album(string name, DateTime releaseDate, string imageBigUrl, string imageSmallUrl, Artist artist, DateTime createdAt, DateTime updatedAt, List<Song> songs)
        {
            Name = name;
            ReleaseDate = releaseDate;
            ImageBigUrl = imageBigUrl;
            ImageSmallUrl = imageSmallUrl;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Artist = artist;
            Songs = songs;
        }

        public Album(string name, DateTime releaseDate, string imageBigUrl, string imageSmallUrl, Artist artist, DateTime createdAt, DateTime updatedAt)
        {
            Name = name;
            ReleaseDate = releaseDate;
            ImageBigUrl = imageBigUrl;
            ImageSmallUrl = imageSmallUrl;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Artist = artist;
        }

        public Album(string name, DateTime releaseDate, string imageBigUrl, string imageSmallUrl, DateTime createdAt, DateTime updatedAt)
        {
            Name = name;
            ReleaseDate = releaseDate;
            ImageBigUrl = imageBigUrl;
            ImageSmallUrl = imageSmallUrl;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public Album(int id, string name, string image)
        {
            this.Id = id;
            this.Name = name;
            this.ImageSmallUrl = image;
        }


        public Album()
        {
            
        }
    }
}
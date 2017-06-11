using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a Genre name")]
        [Display(Name = "Genre Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the Genre description")]
        [Display(Name = "Genre Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please add an image to this Genre")]
        [Display(Name = "Genre Image")]
        public string ImageUrl { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get;  set; }
        [Required]
        public bool Public { get; set; }

        // List
        public List<Artist> Artists { get; set; }
        public List<Song> Songs { get; set; }

        public Genre(int id, string name, string description, string imageUrl, bool Public, DateTime createdAt, DateTime? updatedAt)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            this.Public = Public;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public Genre(int id, string name, string description, string imageUrl, bool Public, DateTime createdAt, DateTime? updatedAt, List<Artist> artists)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            this.Public = Public;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Artists = artists;
        }

        public Genre(int id, string name, string description, string imageUrl, bool Public, DateTime createdAt, DateTime? updatedAt, List<Song> songs)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            this.Public = Public;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Songs = songs;
        }
        public Genre(int id, string name, string description, string imageUrl, bool Public, DateTime createdAt, DateTime? updatedAt, List<Song> songs, List<Artist> artists)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            this.Public = Public;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Songs = songs;
            Artists = artists;
        }

        public Genre(int id, string name, string imageUrl)
        {
            this.Id = id;
            this.Name = name;
            this.ImageUrl = imageUrl;
        }

        public Genre()
        {
            
        }
    }
}
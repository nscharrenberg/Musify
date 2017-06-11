using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Artist
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter an Artist name")]
        [Display(Name = "Artist Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please add an image of the Artist")]
        [Display(Name = "Artist Image")]
        public string ImageBigUrl { get; set; }

        [Required(ErrorMessage = "Please add a thumbnail image of the Artist")]
        [Display(Name = "Artist thumbnail")]
        public string ImageSmallUrl { get; set; }

        [Required(ErrorMessage = "Please enter the Artist's biography")]
        [Display(Name = "Artist Biography")]
        [DataType(DataType.MultilineText)]
        public string Biography { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // List
        public List<Genre> Genres { get; set; }
        public List<Album> Albums { get; set; }

        public Artist(int id, string name, string imageBigUrl, string imageSmallUrl, string biography, DateTime createdAt, DateTime? updatedAt, List<Genre> genres, List<Album> albums)
        {
            Id = id;
            Name = name;
            ImageBigUrl = imageBigUrl;
            ImageSmallUrl = imageSmallUrl;
            Biography = biography;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Genres = genres;
            Albums = albums;
        }

        public Artist(int id, string name, string imageBigUrl, string imageSmallUrl, string biography, DateTime createdAt, DateTime? updatedAt, List<Genre> genres)
        {
            Id = id;
            Name = name;
            ImageBigUrl = imageBigUrl;
            ImageSmallUrl = imageSmallUrl;
            Biography = biography;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Genres = genres;
        }

        public Artist(int id, string name, string imageBigUrl, string imageSmallUrl, string biography, DateTime createdAt, DateTime? updatedAt, List<Album> albums)
        {
            Id = id;
            Name = name;
            ImageBigUrl = imageBigUrl;
            ImageSmallUrl = imageSmallUrl;
            Biography = biography;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Albums = albums;
        }

        public Artist(int id, string name, string imageBigUrl, string imageSmallUrl, string biography, DateTime createdAt, DateTime? updatedAt)
        {
            Id = id;
            Name = name;
            ImageBigUrl = imageBigUrl;
            ImageSmallUrl = imageSmallUrl;
            Biography = biography;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public Artist(int id, string name, string image)
        {
            this.Id = id;
            this.Name = name;
            this.ImageSmallUrl = image;
        }

        public Artist()
        {
            
        }
    }
}
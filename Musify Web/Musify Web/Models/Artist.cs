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
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageBigUrl { get; set; }
        [Required]
        public string ImageSmallUrl { get; set; }
        [Required]
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

        public Artist()
        {
            
        }
    }
}
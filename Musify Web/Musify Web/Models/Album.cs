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
        public string Image { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public List<Song> Songs { get; private set; }


        public Album(string name, DateTime releaseDate, string image, DateTime createdAt, DateTime updatedAt)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Image = image;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public Album(int id, string name, DateTime releaseDate, string image, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
            Image = image;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public Album(string name, DateTime releaseDate, string image, DateTime createdAt, DateTime updatedAt, List<Song> songs)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Image = image;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Songs = songs;
        }

        public Album(int id, string name, DateTime releaseDate, string image, DateTime createdAt, DateTime updatedAt, List<Song> songs)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
            Image = image;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Songs = songs;
        }
    }
}
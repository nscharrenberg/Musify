using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Playlist
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public bool Public { get; private set; }
        public bool Owner { get; private set; }
        public bool System { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public List<Song> Songs { get; private set; }

        public Playlist(string name, string description, string image, bool @public, bool owner, bool system,
            DateTime createdAt, DateTime updatedAt)
        {
            Name = name;
            Description = description;
            Image = image;
            Public = @public;
            Owner = owner;
            System = system;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public Playlist(int id, string name, string description, string image, bool @public, bool owner, bool system,
            DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Public = @public;
            Owner = owner;
            System = system;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }


        public Playlist(string name, string description, string image, bool @public, bool owner, bool system,
            DateTime createdAt, DateTime updatedAt, List<Song> songs)
        {
            Name = name;
            Description = description;
            Image = image;
            Public = @public;
            Owner = owner;
            System = system;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Songs = songs;
        }

        public Playlist(int id, string name, string description, string image, bool @public, bool owner, bool system,
            DateTime createdAt, DateTime updatedAt, List<Song> songs)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Public = @public;
            Owner = owner;
            System = system;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Songs = songs;
        }
    }
}
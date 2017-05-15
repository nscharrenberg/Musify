using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models
{
    public class Artist
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Biography { get; private set; }
        public string BigImage { get; private set; }
        public string SmallImage { get; private set; }
        public List<Genre> Genres { get; private set; }
        public List<Album> Albums { get; private set; }


        public Artist(int _id)
        {
            Id = _id;
        }

        public Artist(string name, string biography, string bigImage, string smallImage)
        {
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;

        }

        public Artist(int id, string name, string biography, string bigImage, string smallImage)
        {
            Id = id;
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;
        }

        public Artist(string name, string biography, string bigImage, string smallImage, List<Album> albums)
        {
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;
            Albums = albums;
        }

        public Artist(int id, string name, string biography, string bigImage, string smallImage, List<Album> albums)
        {
            Id = id;
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;
            Albums = albums;
        }

        public Artist(string name, string biography, string bigImage, string smallImage, List<Genre> genres)
        {
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;
            Genres = genres;

        }

        public Artist(int id, string name, string biography, string bigImage, string smallImage, List<Genre> genres)
        {
            Id = id;
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;
            Genres = genres;
        }

        public Artist(string name, string biography, string bigImage, string smallImage, List<Genre> genres, List<Album> albums)
        {
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;
            Genres = genres;
            Albums = albums;

        }

        public Artist(int id, string name, string biography, string bigImage, string smallImage, List<Genre> genres, List<Album> albums)
        {
            Id = id;
            Name = name;
            Biography = biography;
            BigImage = bigImage;
            SmallImage = smallImage;
            Genres = genres;
            Albums = albums;
        }

        public override string ToString()
        {
            return Id + "   " + Name + "   " + Biography + "   " + BigImage;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Musify_Web.Models.Interface;
using Musify_Web.Repository.Interface;

namespace Musify_Web.Models.Repository
{
    public class ArtistRepository
    {
        private IArtistsContext context;

        public ArtistRepository(IArtistsContext context)
        {
            this.context = context;
        }

        public Artist[] GetAllArtists()
        {
            return context.GetAllArtists().ToArray();
        }

        public List<Genre> GetGenreArtists(int artistId)
        {
            return context.GetGenreArtists(artistId);
        }

        public Artist GetArtistById(int artistId)
        {
            return context.GetArtistById(artistId);
        }

        public void AddArtist(Artist artist)
        {
            context.AddArtist(artist);
        }

        public void DeleteArtistById(int artistId)
        {
            context.DeleteArtistById(artistId);
        }

        public Artist UpdateArtistById(Artist artist)
        {
            return context.UpdateArtistById(artist);
        }

        public Artist SetUpdateTimeForArtistById(Artist artist)
        {
            return context.SetUpdateTimeForArtistById(artist);
        }

        public void AddGenreToArtist(int artist, int genre)
        {
            context.AddGenreToArtist(artist, genre);
        }

        public void RemoveGenreFromArtist(int artist, int genre)
        {
            context.RemoveGenreFromArtist(artist, genre);
        }

        public List<Album> GetAlbumArtists(int id)
        {
            return context.GetAlbumArtists(id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musify_Application.Interface;

namespace Musify_Application.Repository
{
    class ArtistRepository
    {
        private IArtistContext context;

        public ArtistRepository(IArtistContext context)
        {
            this.context = context;
        }

        public void AddArtist(string name, string biography, string BigImage, string smallImage)
        {
            context.AddArtist(name, biography, BigImage, smallImage);
        }

        public Artist[] AllArtists()
        {
           return context.AllArtists().ToArray();
        }

        public Artist SearchArtistByName(string name)
        {
            return context.SearchArtistByName(name);
        }

        public Artist SearchArtistById(int id)
        {
            return context.SearchArtistById(id);
        }

        public void UpdateArtist(int id, string name, string biography, string bigImage, string smallImage)
        {
            context.UpdateArtist(id, name, biography, bigImage, smallImage);
        }

        public void AddGenreToArtist(int artistId, int genreId)
        {
            context.AddGenreToArtist(artistId, genreId);
        }
        public void RefreshList()
        {
            context.RefreshList();
        }

        public void DeleteArtistById(int id)
        {
            context.DeleteArtistById(id);
        }

        public List<Genre> GetGenreOfArtist(int artistId)
        {
            return context.GetGenreOfArtist(artistId);
        }
    }
}
